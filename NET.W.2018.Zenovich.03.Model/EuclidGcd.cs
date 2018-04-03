using NET.W._2018.Zenovich._03.API;
using System;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// Allows to get gcd of several numbers.
    /// </summary>
    public class EuclidGcd : TimerGcd
    {
        public EuclidGcd()
        {

        }

        public EuclidGcd(ITimer timer)
            : base(timer)
        {

        }

        /// <summary>
        /// Implementations binary gcd algorithm for two parameters.
        /// </summary>
        /// <param name="left">First number will be used in gcd calculation.</param>
        /// <param name="right">Second number will be used in gcd calculation.</param>
        /// <returns>Gcd of two parameters</returns>
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
