using System;

namespace NET.W._2018.Zenovich._03.API
{
    public interface ITimer
    {
        void Start();
        void Stop();
        TimeSpan GetTimeSpan();
    }
}
