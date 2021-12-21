namespace NumberRandom
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCurrentNumber = new System.Windows.Forms.Label();
            this.labelNumberTip = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRangeMin = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelRangeTo = new System.Windows.Forms.Label();
            this.txtRangeMax = new System.Windows.Forms.TextBox();
            this.btnStartRandom = new System.Windows.Forms.Button();
            this.btnStopRandom = new System.Windows.Forms.Button();
            this.btnPickNumber = new System.Windows.Forms.Button();
            this.txtAutomaticAmount = new System.Windows.Forms.TextBox();
            this.labelAutomaticAmount = new System.Windows.Forms.Label();
            this.labelAutomaticDelay = new System.Windows.Forms.Label();
            this.txtAutomaticDelay = new System.Windows.Forms.TextBox();
            this.btnAutomaticStart = new System.Windows.Forms.Button();
            this.labelRandomDelay = new System.Windows.Forms.Label();
            this.timerRandom = new System.Windows.Forms.Timer(this.components);
            this.txtRandomDelay = new System.Windows.Forms.TextBox();
            this.labelRandomDelayUnit = new System.Windows.Forms.Label();
            this.timerAutomatic = new System.Windows.Forms.Timer(this.components);
            this.labelExcept = new System.Windows.Forms.Label();
            this.txtExcept = new System.Windows.Forms.TextBox();
            this.chkNoSame = new System.Windows.Forms.CheckBox();
            this.btnAutomaticStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCurrentNumber
            // 
            this.labelCurrentNumber.AutoSize = true;
            this.labelCurrentNumber.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCurrentNumber.Location = new System.Drawing.Point(35, 40);
            this.labelCurrentNumber.Name = "labelCurrentNumber";
            this.labelCurrentNumber.Size = new System.Drawing.Size(41, 47);
            this.labelCurrentNumber.TabIndex = 1;
            this.labelCurrentNumber.Text = "0";
            // 
            // labelNumberTip
            // 
            this.labelNumberTip.AutoSize = true;
            this.labelNumberTip.Location = new System.Drawing.Point(15, 15);
            this.labelNumberTip.Name = "labelNumberTip";
            this.labelNumberTip.Size = new System.Drawing.Size(65, 12);
            this.labelNumberTip.TabIndex = 0;
            this.labelNumberTip.Text = "目前號碼：";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(15, 125);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(65, 12);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "輸出結果：";
            // 
            // lvOutput
            // 
            this.lvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.number});
            this.lvOutput.Location = new System.Drawing.Point(86, 125);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(220, 269);
            this.lvOutput.TabIndex = 3;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "編號";
            this.id.Width = 75;
            // 
            // number
            // 
            this.number.Text = "數值";
            this.number.Width = 120;
            // 
            // txtRangeMin
            // 
            this.txtRangeMin.Location = new System.Drawing.Point(337, 30);
            this.txtRangeMin.Name = "txtRangeMin";
            this.txtRangeMin.Size = new System.Drawing.Size(70, 22);
            this.txtRangeMin.TabIndex = 5;
            this.txtRangeMin.Text = "1";
            this.txtRangeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(335, 15);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(41, 12);
            this.labelRange.TabIndex = 4;
            this.labelRange.Text = "範圍：";
            // 
            // labelRangeTo
            // 
            this.labelRangeTo.AutoSize = true;
            this.labelRangeTo.Location = new System.Drawing.Point(413, 33);
            this.labelRangeTo.Name = "labelRangeTo";
            this.labelRangeTo.Size = new System.Drawing.Size(11, 12);
            this.labelRangeTo.TabIndex = 6;
            this.labelRangeTo.Text = "~";
            // 
            // txtRangeMax
            // 
            this.txtRangeMax.Location = new System.Drawing.Point(430, 30);
            this.txtRangeMax.Name = "txtRangeMax";
            this.txtRangeMax.Size = new System.Drawing.Size(70, 22);
            this.txtRangeMax.TabIndex = 7;
            this.txtRangeMax.Text = "100";
            this.txtRangeMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly);
            // 
            // btnStartRandom
            // 
            this.btnStartRandom.Location = new System.Drawing.Point(337, 58);
            this.btnStartRandom.Name = "btnStartRandom";
            this.btnStartRandom.Size = new System.Drawing.Size(75, 23);
            this.btnStartRandom.TabIndex = 8;
            this.btnStartRandom.Text = "亂數開始";
            this.btnStartRandom.UseVisualStyleBackColor = true;
            this.btnStartRandom.Click += new System.EventHandler(this.btnStartRandom_Click);
            // 
            // btnStopRandom
            // 
            this.btnStopRandom.Enabled = false;
            this.btnStopRandom.Location = new System.Drawing.Point(418, 58);
            this.btnStopRandom.Name = "btnStopRandom";
            this.btnStopRandom.Size = new System.Drawing.Size(75, 23);
            this.btnStopRandom.TabIndex = 9;
            this.btnStopRandom.Text = "亂數停止";
            this.btnStopRandom.UseVisualStyleBackColor = true;
            this.btnStopRandom.Click += new System.EventHandler(this.btnStopRandom_Click);
            // 
            // btnPickNumber
            // 
            this.btnPickNumber.Enabled = false;
            this.btnPickNumber.Location = new System.Drawing.Point(337, 115);
            this.btnPickNumber.Name = "btnPickNumber";
            this.btnPickNumber.Size = new System.Drawing.Size(75, 23);
            this.btnPickNumber.TabIndex = 13;
            this.btnPickNumber.Text = "亂數選號";
            this.btnPickNumber.UseVisualStyleBackColor = true;
            this.btnPickNumber.Click += new System.EventHandler(this.btnPickNumber_Click);
            // 
            // txtAutomaticAmount
            // 
            this.txtAutomaticAmount.Enabled = false;
            this.txtAutomaticAmount.Location = new System.Drawing.Point(394, 155);
            this.txtAutomaticAmount.Name = "txtAutomaticAmount";
            this.txtAutomaticAmount.Size = new System.Drawing.Size(135, 22);
            this.txtAutomaticAmount.TabIndex = 16;
            this.txtAutomaticAmount.Text = "5";
            this.txtAutomaticAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly);
            // 
            // labelAutomaticAmount
            // 
            this.labelAutomaticAmount.AutoSize = true;
            this.labelAutomaticAmount.Location = new System.Drawing.Point(335, 158);
            this.labelAutomaticAmount.Name = "labelAutomaticAmount";
            this.labelAutomaticAmount.Size = new System.Drawing.Size(53, 12);
            this.labelAutomaticAmount.TabIndex = 15;
            this.labelAutomaticAmount.Text = "選取數量";
            // 
            // labelAutomaticDelay
            // 
            this.labelAutomaticDelay.AutoSize = true;
            this.labelAutomaticDelay.Location = new System.Drawing.Point(335, 186);
            this.labelAutomaticDelay.Name = "labelAutomaticDelay";
            this.labelAutomaticDelay.Size = new System.Drawing.Size(88, 12);
            this.labelAutomaticDelay.TabIndex = 17;
            this.labelAutomaticDelay.Text = "延遲時間 (毫秒)";
            // 
            // txtAutomaticDelay
            // 
            this.txtAutomaticDelay.Enabled = false;
            this.txtAutomaticDelay.Location = new System.Drawing.Point(429, 183);
            this.txtAutomaticDelay.Name = "txtAutomaticDelay";
            this.txtAutomaticDelay.Size = new System.Drawing.Size(100, 22);
            this.txtAutomaticDelay.TabIndex = 18;
            this.txtAutomaticDelay.Text = "1500";
            this.txtAutomaticDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly);
            // 
            // btnAutomaticStart
            // 
            this.btnAutomaticStart.Enabled = false;
            this.btnAutomaticStart.Location = new System.Drawing.Point(373, 211);
            this.btnAutomaticStart.Name = "btnAutomaticStart";
            this.btnAutomaticStart.Size = new System.Drawing.Size(75, 23);
            this.btnAutomaticStart.TabIndex = 19;
            this.btnAutomaticStart.Text = "自動選號";
            this.btnAutomaticStart.UseVisualStyleBackColor = true;
            this.btnAutomaticStart.Click += new System.EventHandler(this.btnAutomaticStart_Click);
            // 
            // labelRandomDelay
            // 
            this.labelRandomDelay.AutoSize = true;
            this.labelRandomDelay.Location = new System.Drawing.Point(515, 15);
            this.labelRandomDelay.Name = "labelRandomDelay";
            this.labelRandomDelay.Size = new System.Drawing.Size(65, 12);
            this.labelRandomDelay.TabIndex = 10;
            this.labelRandomDelay.Text = "亂數延遲：";
            // 
            // timerRandom
            // 
            this.timerRandom.Tick += new System.EventHandler(this.timerRandom_Tick);
            // 
            // txtRandomDelay
            // 
            this.txtRandomDelay.Location = new System.Drawing.Point(517, 30);
            this.txtRandomDelay.Name = "txtRandomDelay";
            this.txtRandomDelay.Size = new System.Drawing.Size(80, 22);
            this.txtRandomDelay.TabIndex = 11;
            this.txtRandomDelay.Text = "100";
            this.txtRandomDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnly);
            // 
            // labelRandomDelayUnit
            // 
            this.labelRandomDelayUnit.AutoSize = true;
            this.labelRandomDelayUnit.Location = new System.Drawing.Point(568, 55);
            this.labelRandomDelayUnit.Name = "labelRandomDelayUnit";
            this.labelRandomDelayUnit.Size = new System.Drawing.Size(29, 12);
            this.labelRandomDelayUnit.TabIndex = 12;
            this.labelRandomDelayUnit.Text = "毫秒";
            // 
            // timerAutomatic
            // 
            this.timerAutomatic.Tick += new System.EventHandler(this.timerAutomatic_Tick);
            // 
            // labelExcept
            // 
            this.labelExcept.AutoSize = true;
            this.labelExcept.Location = new System.Drawing.Point(335, 375);
            this.labelExcept.Name = "labelExcept";
            this.labelExcept.Size = new System.Drawing.Size(112, 12);
            this.labelExcept.TabIndex = 22;
            this.labelExcept.Text = "排除號碼 (空格隔開)";
            // 
            // txtExcept
            // 
            this.txtExcept.Location = new System.Drawing.Point(453, 372);
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(144, 22);
            this.txtExcept.TabIndex = 23;
            this.txtExcept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberAndSpaceOnly);
            // 
            // chkNoSame
            // 
            this.chkNoSame.AutoSize = true;
            this.chkNoSame.Location = new System.Drawing.Point(337, 350);
            this.chkNoSame.Name = "chkNoSame";
            this.chkNoSame.Size = new System.Drawing.Size(84, 16);
            this.chkNoSame.TabIndex = 21;
            this.chkNoSame.Text = "不抽取重複";
            this.chkNoSame.UseVisualStyleBackColor = true;
            // 
            // btnAutomaticStop
            // 
            this.btnAutomaticStop.Enabled = false;
            this.btnAutomaticStop.Location = new System.Drawing.Point(454, 211);
            this.btnAutomaticStop.Name = "btnAutomaticStop";
            this.btnAutomaticStop.Size = new System.Drawing.Size(75, 23);
            this.btnAutomaticStop.TabIndex = 20;
            this.btnAutomaticStop.Text = "中止選號";
            this.btnAutomaticStop.UseVisualStyleBackColor = true;
            this.btnAutomaticStop.Click += new System.EventHandler(this.btnAutomaticStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清除紀錄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAutomaticStop);
            this.Controls.Add(this.chkNoSame);
            this.Controls.Add(this.txtExcept);
            this.Controls.Add(this.labelExcept);
            this.Controls.Add(this.labelRandomDelayUnit);
            this.Controls.Add(this.txtRandomDelay);
            this.Controls.Add(this.labelRandomDelay);
            this.Controls.Add(this.btnAutomaticStart);
            this.Controls.Add(this.txtAutomaticDelay);
            this.Controls.Add(this.labelAutomaticDelay);
            this.Controls.Add(this.labelAutomaticAmount);
            this.Controls.Add(this.txtAutomaticAmount);
            this.Controls.Add(this.btnPickNumber);
            this.Controls.Add(this.btnStopRandom);
            this.Controls.Add(this.btnStartRandom);
            this.Controls.Add(this.txtRangeMax);
            this.Controls.Add(this.labelRangeTo);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.txtRangeMin);
            this.Controls.Add(this.lvOutput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelNumberTip);
            this.Controls.Add(this.labelCurrentNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "亂數簽筒";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentNumber;
        private System.Windows.Forms.Label labelNumberTip;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.TextBox txtRangeMin;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelRangeTo;
        private System.Windows.Forms.TextBox txtRangeMax;
        private System.Windows.Forms.Button btnStartRandom;
        private System.Windows.Forms.Button btnStopRandom;
        private System.Windows.Forms.Button btnPickNumber;
        private System.Windows.Forms.TextBox txtAutomaticAmount;
        private System.Windows.Forms.Label labelAutomaticAmount;
        private System.Windows.Forms.Label labelAutomaticDelay;
        private System.Windows.Forms.TextBox txtAutomaticDelay;
        private System.Windows.Forms.Button btnAutomaticStart;
        private System.Windows.Forms.Label labelRandomDelay;
        private System.Windows.Forms.Timer timerRandom;
        private System.Windows.Forms.TextBox txtRandomDelay;
        private System.Windows.Forms.Label labelRandomDelayUnit;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Timer timerAutomatic;
        private System.Windows.Forms.Label labelExcept;
        private System.Windows.Forms.TextBox txtExcept;
        private System.Windows.Forms.CheckBox chkNoSame;
        private System.Windows.Forms.Button btnAutomaticStop;
        private System.Windows.Forms.Button btnClear;
    }
}

