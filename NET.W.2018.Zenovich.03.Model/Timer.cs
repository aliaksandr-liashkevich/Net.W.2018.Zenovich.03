using NET.W._2018.Zenovich._03.API;
using System;
using System.Diagnostics;

namespace NET.W._2018.Zenovich._03.Model
{
    public class Timer : ITimer
    {
        private Stopwatch _stopwatch;

        public virtual Stopwatch Stopwatch
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

        public TimeSpan GetTimeSpan()
        {
            return Stopwatch.Elapsed;
        }

        public void Start()
        {
            Stopwatch.Restart();
        }

        public void Stop()
        {
            Stopwatch.Stop();
        }
    }
}
