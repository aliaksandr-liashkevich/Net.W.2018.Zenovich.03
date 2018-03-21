using Moq;
using NET.W._2018.Zenovich._03.API;
using NET.W._2018.Zenovich._03.Model;

namespace NET.W._2018.Zenovich._03.Tests
{
    class DoubleConverterMockUnderTest : DoubleConverter
    {
        public DoubleConverterMockUnderTest(IByteConverter byteConverter)
        {
            this.byteConverter = byteConverter;
        }
    }
}
