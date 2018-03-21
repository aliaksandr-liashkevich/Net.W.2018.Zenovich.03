using NET.W._2018.Zenovich._03.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// convert double number to byte array
    /// </summary>
    public class ByteConverter : IByteConverter
    {
        /// <summary>
        /// implementations converter double number to byte array 
        /// </summary>
        /// <param name="number">number will be used in convertion</param>
        /// <returns>array byte of double number</returns>
        public byte[] GetBytes(double number)
        {
            return BitConverter.GetBytes(number);
        }
    }
}
