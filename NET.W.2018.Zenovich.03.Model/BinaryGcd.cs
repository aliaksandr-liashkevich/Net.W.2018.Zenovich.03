using NET.W._2018.Zenovich._03.API;
using System;

namespace NET.W._2018.Zenovich._03.Model
{
    public class BinaryGcd : TimerGcd
    {
        public BinaryGcd()
        {

        }

        public BinaryGcd(ITimer timer) 
            : base(timer)
        {

        }

        private int CalculateBinaryGcd(int left, int right)
        {
            if (left == 0)
            {
                return right;
            }

            if (right == 0)
            {
                return left;
            }

            if (left == 1 || right == 1)
            {
                return 1;
            }

            if ((left & 1) == 0)
            {
                return ((right & 1) == 0) ?
                    CalculateBinaryGcd(left >> 1, right >> 1) << 1 :
                    CalculateBinaryGcd(left >> 1, right);
            }
            else
            {
                return ((right & 1) == 0) ?
                    CalculateBinaryGcd(left, right >> 1) :
                    CalculateBinaryGcd(right, Math.Abs(left - right));
            }
        }

        protected override int CalculateGcd(int left, int right)
        {
            if (left < 0)
            {
                left = Math.Abs(left);
            }

            if (right < 0)
            {
                left = Math.Abs(right);
            }

            return CalculateBinaryGcd(left, right);
        }
    }
}
