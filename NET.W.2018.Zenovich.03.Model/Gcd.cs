using NET.W._2018.Zenovich._03.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._03.Model
{
    public class Gcd : IGcd
    {
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

        public int CalculateGcd(params int[] numbers)
        {
            int length, result;

            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            length = numbers.Length;

            if (length < 2)
            {
                throw new ArgumentException("Count of numbers should be more than 2");
            }

            result = CalculateGcd(numbers[0], numbers[1]);

            for (int i = 2; i < length; i++)
            {
                result = CalculateGcd(numbers[i], result);
            }

            return result;
        }
    }
}
