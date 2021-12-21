using SkinSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NumberRandom
{
    public partial class MainForm : Form
    {
        private const int loopLimit = 1000; // 避免死循環最大限制次數

        public static readonly SecureRandom random = new SecureRandom();

        private int select, count;
        private readonly SkinH_Net skin;

        private readonly ISet<int> except;
        private readonly ISet<int> only;

        public MainForm()
        {
            InitializeComponent();

            skin = new SkinH_Net();
            skin.AttachEx("Skin.she", "");

            except = new HashSet<int>();
            only = new HashSet<int>();
        }

        private void btnAutomaticStart_Click(object sender, EventArgs e)
        {
            if (!checkAutomaticInputValue())
            {
                MessageBox.Show(this, "輸入數值錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            automaticPickupStartControl(true);
            select = int.Parse(txtAutomaticAmount.Text);
            timerAutomatic.Interval = int.Parse(txtAutomaticDelay.Text);
            timerAutomatic.Start();
        }

        private void btnAutomaticStop_Click(object sender, EventArgs e)
        {
            timerAutomatic.Stop();
            select = 0;
            automaticPickupStartControl(false);
        }

        private void btnPickNumber_Click(object sender, EventArgs e)
        {
            string[] row = pickNumber();
            if (row == null)
            {
                row = new string[] { "無窮迴圈", "程式中止選號" };
                btnAutomaticStop_Click(sender, e);
                btnStopRandom_Click(sender, e);
            }

            ListViewItem number = new ListViewItem(row);
            lvOutput.Items.Add(number);
            lvOutput.EnsureVisible(lvOutput.Items.Count - 1);
        }

        private string[] pickNumber()
        {
            bool success = false;
            int pick = int.Parse(labelCurrentNumber.Text);
            for (int i = 1; !success && i <= loopLimit; ++i)
            {
                if (except.Contains(pick))
                {
                    pick = getRandomNumber();
                    continue;
                }

                if (chkNoSame.Checked)
                {
                    if (only.Contains(pick))
                    {
                        pick = getRandomNumber();
                        continue;
                    }
                    only.Add(pick);
                }
                success = true;
            }
            return success ? new string[] { (++count).ToString(), pick.ToString() } : null;
        }

        private void btnStartRandom_Click(object sender, EventArgs e)
        {
            if (!checkNumberGeneratorInputValue())
            {
                MessageBox.Show(this, "輸入數值錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numberGeneratorStartControl(true);
            btnClear_Click(sender, e);
            loadExceptNumber();

            timerRandom.Interval = int.Parse(txtRandomDelay.Text);
            timerRandom.Start();
        }

        private void btnStopRandom_Click(object sender, EventArgs e)
        {
            timerRandom.Stop();
            numberGeneratorStartControl(false);
        }

        private void timerAutomatic_Tick(object sender, EventArgs e)
        {
            btnPickNumber_Click(sender, e);
            if (--select <= 0)
            {
                timerAutomatic.Stop();
                automaticPickupStartControl(false);
            }
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {
            labelCurrentNumber.Text = getRandomNumber().ToString();
            labelCurrentNumber.Refresh();
        }

        #region 限制輸入

        private void numberAndSpaceOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void numberOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        #endregion 限制輸入

        private void loadExceptNumber()
        {
            except.Clear();
            if (txtExcept.Text == "")
            {
                return;
            }
            string[] data = txtExcept.Text.Split(' ');
            foreach (string splitNumber in data)
            {
                try
                {
                    int number = int.Parse(splitNumber);
                    except.Add(number);
                }
                catch
                {
                    MessageBox.Show(splitNumber + " 不是一個有效的數值 已跳過 ...");
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (int number in except)
            {
                sb.Append(number).Append(" ");
            }
            --sb.Length;
            txtExcept.Text = sb.ToString();
        }

        private int getRandomNumber()
        {
            return random.Next(int.Parse(txtRangeMin.Text), int.Parse(txtRangeMax.Text) + 1);
        }

        private bool checkNumberGeneratorInputValue()
        {
            int min, max, interval;
            try
            {
                min = int.Parse(txtRangeMin.Text);
                max = int.Parse((long.Parse(txtRangeMax.Text) + 1).ToString());
                interval = int.Parse(txtRandomDelay.Text);
            }
            catch
            {
                return false;
            }
            if (min > max || interval <= 0)
            {
                return false;
            }
            return true;
        }

        private bool checkAutomaticInputValue()
        {
            int amount, delay;
            try
            {
                amount = int.Parse(txtAutomaticAmount.Text);
                delay = int.Parse(txtAutomaticDelay.Text);
            }
            catch
            {
                return false;
            }
            if (amount <= 0 || delay <= 0)
            {
                return false;
            }
            return true;
        }

        private void automaticPickupStartControl(bool start)
        {
            txtAutomaticAmount.Enabled = !start;
            txtAutomaticDelay.Enabled = !start;
            btnAutomaticStart.Enabled = !start;
            btnAutomaticStop.Enabled = start;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvOutput.Items.Clear();
            only.Clear();
            count = 0;
        }

        private void numberGeneratorStartControl(bool start)
        {
            txtRangeMin.Enabled = !start;
            txtRangeMax.Enabled = !start;
            txtRandomDelay.Enabled = !start;
            btnStartRandom.Enabled = !start;
            btnStopRandom.Enabled = start;

            btnPickNumber.Enabled = start;

            txtAutomaticAmount.Enabled = start;
            txtAutomaticDelay.Enabled = start;
            btnAutomaticStart.Enabled = start;
            if (!start)
            {
                timerAutomatic.Stop();
                btnAutomaticStop.Enabled = start;
            }

            chkNoSame.Enabled = !start;
            txtExcept.Enabled = !start;
        }
    }
}