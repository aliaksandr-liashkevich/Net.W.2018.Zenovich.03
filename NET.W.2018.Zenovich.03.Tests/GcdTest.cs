using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._03.API;
using NET.W._2018.Zenovich._03.Model;

namespace NET.W._2018.Zenovich._03.Tests
{
    [TestClass]
    public class GcdTest
    {
        public TestContext TestContext { get; set; }
        private static IGcd gcd;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            gcd = new Gcd();
        }

        [TestMethod]
        [DeploymentItem("Files\\numbersGcd.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "numbersGcd.xml",
        "Number",
        DataAccessMethod.Sequential)]
        public void CalculateGcd_NumbersFromXml_ExpectedValuesFromXml()
        {
            // arrange
            string[] numbersXml = Convert.ToString(TestContext.DataRow["numbers"]).Split(',');
            int length = numbersXml.Length;

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersXml[i]);
            }
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            // act
            int actual = gcd.CalculateGcd(numbers);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CalculatedGcd_NullNumbers_ArgumentNullException()
        {
            // arrange
            int[] numbers = null;

            // act
            gcd.CalculateGcd(numbers);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatedGcd_OneParam_ArgumentException()
        {
            // arrange
            int[] numbers = new int[]
            {
                1
            };

            // act
            gcd.CalculateGcd(numbers);
        }
    }
}
