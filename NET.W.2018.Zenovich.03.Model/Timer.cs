using NET.W._2018.Zenovich._03.API;
using System;
using System.Diagnostics;

namespace NET.W._2018.Zenovich._03.Model
{
    /// <summary>
    /// Calculate time of gcd operation.
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
        /// Get time span from timer.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetTimeSpan()
        {
            return Stopwatch.Elapsed;
        }

        /// <summary>
        /// Starts timer.
        /// </summary>
        public void Start()
        {
            Stopwatch.Restart();
        }

        /// <summary>
        /// Stops timer.
        /// </summary>
        public void Stop()
        {
            Stopwatch.Stop();
        }
    }
}
