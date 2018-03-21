using NET.W._2018.Zenovich._03.API;
using System;
using System.Diagnostics;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// calculate time of gcd operation
    /// </summary>
    public class Timer : ITimer
    {
        private Stopwatch _stopwatch;

        protected virtual Stopwatch Stopwatch
        {
            get
            {
                if (_stopwatch == null)
                {
                    _stopwatch = new Stopwatch(); 
                }

                return _stopwatch;
            }
        }

        /// <summary>
        /// get timespan from timer
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetTimeSpan()
        {
            return Stopwatch.Elapsed;
        }

        /// <summary>
        /// starts timer
        /// </summary>
        public void Start()
        {
            Stopwatch.Restart();
        }

        /// <summary>
        /// stops timer
        /// </summary>
        public void Stop()
        {
            Stopwatch.Stop();
        }
    }
}
