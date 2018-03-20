using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._03.API;
using NET.W._2018.Zenovich._03.Model;

namespace NET.W._2018.Zenovich._03.Tests
{
    [TestClass]
    public class BinaryGcdTest : GcdTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            gcd = new BinaryGcd();
        }

        protected override IGcd FactoryMethod(ITimer timer)
        {
            return new BinaryGcd(timer);
        }
    }
}
