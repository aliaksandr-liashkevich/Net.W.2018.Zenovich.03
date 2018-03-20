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

        private int CalculateGcd(int left, int right)
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

        protected override int ModelGcd(int[] numbers)
        {
            int length = numbers.Length, result = 0;

            result = CalculateGcd(numbers[0], numbers[1]);

            for (int i = 2; i < length; i++)
            {
                result = CalculateGcd(numbers[i], result);
            }

            return result;
        }
    }
}
