using System;
using System.Security.Cryptography;

namespace NumberRandom
{
    // Java SecureRandom ���O���Ӫ���
    public class SecureRandom : Random
    {
        private int bufferPosition;
        private byte[] _buffer;
        private readonly RNGCryptoServiceProvider rng;

        public bool isRandomPoolEnable { get; private set; }

        public SecureRandom() : this(true)
        {
        }

        public SecureRandom(int ignoreSeed) : this(true)
        {
        }

        public SecureRandom(bool enableRandomPool)
        {
            rng = new RNGCryptoServiceProvider();
            isRandomPoolEnable = enableRandomPool;
        }

        private void initBuffer()
        {
            if (isRandomPoolEnable)
            {
                if (_buffer == null || _buffer.Length != 512)
                {
                    _buffer = new byte[512];
                }
            }
            else
            {
                if (_buffer == null || _buffer.Length != 4)
                {
                    _buffer = new byte[4];
                }
            }

            rng.GetBytes(_buffer);
            bufferPosition = 0;
        }

        public override int Next()
        {
            return (int)getRandomUInt32() & 0x7FFFFFFF;
        }

        public override int Next(int maxValue)
        {
            if (maxValue < 0)
            {
                throw new ArgumentOutOfRangeException("�̤j�ȰѼƿ��~");
            }
            return Next(0, maxValue);
        }

        public override int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException("�̤p�ȰѼƿ��~");
            }
            if (minValue == maxValue)
            {
                return minValue;
            }

            long diff = maxValue - minValue;
            while (true)
            {
                uint rand = getRandomUInt32();

                long max = 1 + (long)uint.MaxValue;
                long remainder = max % diff;
                if (rand < max - remainder)
                {
                    return (int)(minValue + (rand % diff));
                }
            }
        }

        public override double NextDouble()
        {
            return getRandomUInt32() / (1D + uint.MaxValue);
        }

        public override void NextBytes(byte[] buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException("buffer �Ѽƿ��~");
            }
            lock (this)
            {
                if (isRandomPoolEnable && _buffer == null)
                {
                    initBuffer();
                }
                if (isRandomPoolEnable && _buffer.Length <= buffer.Length)
                {
                    int count = buffer.Length;
                    ensureRandomBuffer(count);
                    Buffer.BlockCopy(_buffer, bufferPosition, buffer, 0, count);
                    bufferPosition += count;
                }
                else
                {
                    rng.GetBytes(buffer);
                }
            }
        }

        private uint getRandomUInt32()
        {
            lock (this)
            {
                ensureRandomBuffer(4);
                uint rand = BitConverter.ToUInt32(_buffer, bufferPosition);
                bufferPosition += 4;
                return rand;
            }
        }

        private void ensureRandomBuffer(int requireByte)
        {
            if (_buffer == null)
            {
                initBuffer();
            }
            if (requireByte > _buffer.Length)
            {
                throw new ArgumentOutOfRangeException("requireByte", "���o�j���H�� buffer");
            }
            if (_buffer.Length - bufferPosition < requireByte)
            {
                initBuffer();
            }
        }
    }
}