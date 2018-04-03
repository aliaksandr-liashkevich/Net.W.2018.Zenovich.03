using NET.W._2018.Zenovich._03.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// Convert double number to byte array.
    /// </summary>
    public class ByteConverter : IByteConverter
    {
        /// <summary>
        /// Implementations converter double number to byte array.
        /// </summary>
        /// <param name="number">Number will be used in convention.</param>
        /// <returns>Array byte of double number.</returns>
        public byte[] GetBytes(double number)
        {
            return BitConverter.GetBytes(number);
        }
    }
}
