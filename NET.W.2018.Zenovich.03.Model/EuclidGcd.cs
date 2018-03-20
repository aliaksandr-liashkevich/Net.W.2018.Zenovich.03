using NET.W._2018.Zenovich._03.API;
using System;

namespace NET.W._2018.Zenovich._03.Model
{
    public class EuclidGcd : TimerGcd
    {
        public EuclidGcd()
        {

        }

        public EuclidGcd(ITimer timer)
            : base(timer)
        {

        }

        protected override int CalculateGcd(int left, int right)
        {
            int temp;
            while (right != 0)
            {
                temp = left % right;
                left = right;
                right = temp;
            }

            return Math.Abs(left);
        }
    }
}
