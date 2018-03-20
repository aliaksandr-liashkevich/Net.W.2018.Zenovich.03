using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._03.API;
using NET.W._2018.Zenovich._03.Model;

using Thread = System.Threading.Thread;

namespace NET.W._2018.Zenovich._03.Tests
{
    [TestClass]
    public class TimerTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void GetTimeSpan_TimeSpanShouldBePositive()
        {
            // arrange
            ITimer timer = new Timer();

            // act
            timer.Start();
            Thread.Sleep(5);
            timer.Stop();
            TestContext.WriteLine($"Time in milliseconds = {timer.GetTimeSpan().Milliseconds}");

            // assert
            Assert.IsTrue(timer.GetTimeSpan().Milliseconds > 0);
        }

        [TestMethod]
        public void GetTimeSpan_TimeSpanShouldBeBiggerOrEqualThan1Second()
        {
            // arrange
            ITimer timer = new Timer();

            // act
            timer.Start();
            Thread.Sleep(1000);
            timer.Stop();
            TestContext.WriteLine($"Time in seconds = {timer.GetTimeSpan().Seconds}");

            // assert
            Assert.IsTrue(timer.GetTimeSpan().Seconds >= 1);
        }
    }
}
