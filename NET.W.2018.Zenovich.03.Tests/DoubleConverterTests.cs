using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._03.API;
using NET.W._2018.Zenovich._03.Model;

namespace NET.W._2018.Zenovich._03.Tests
{
    [TestClass]
    public class DoubleConverterTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem("Files\\doubleNumbers.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "doubleNumbers.xml",
        "Number",
        DataAccessMethod.Sequential)]
        public void Convert_NumbersFromXml_ExpectedValuesFromXml()
        {
            // arrange
            IDoubleConverter doubleConverter = new DoubleConverter();
            string value = TestContext.DataRow["value"].ToString();

            double number;
            switch (value)
            {
                case "MinValue":
                    number = Double.MinValue;
                    break;

                case "MaxValue":
                    number = Double.MaxValue;
                    break;

                case "Epsilon":
                    number = Double.Epsilon;
                    break;

                case "NaN":
                    number = Double.NaN;
                    break;

                case "NegativeInfinity":
                    number = Double.NegativeInfinity;
                    break;

                case "PositiveInfinity":
                    number = Double.PositiveInfinity;
                    break;

                default:
                    number = Convert.ToDouble(value, CultureInfo.InvariantCulture);
                    break;
            }
            

            String expected = TestContext.DataRow["expected"].ToString();

            // act
            String actual = doubleConverter.Convert(number);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
