using NET.W._2018.Zenovich._03.API;
using System.Linq;

using SysConvert = System.Convert;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// Convert double number to string.
    /// </summary>
    public class DoubleConverter : IDoubleConverter
    {
        protected IByteConverter byteConverter;

        protected virtual IByteConverter ByteConverter
        {
            get
            {
                if (byteConverter == null)
                {
                    byteConverter = new ByteConverter();
                }

                return byteConverter;
            }
        }

        /// <summary>
        /// Implementations convert double number to string.
        /// </summary>
        /// <param name="number">Number will be used in conversation.</param>
        /// <returns>String of double number.</returns>
        public string Convert(double number)
        {
            byte[] bytes = ByteConverter.GetBytes(number);
            string result = string.Empty;

            foreach (byte b in bytes.Reverse())
            {
                result += SysConvert.ToString(b, 2).PadLeft(8, '0');
            }

            return result;
        }
    }
}
