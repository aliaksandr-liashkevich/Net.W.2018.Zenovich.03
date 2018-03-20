using System;

namespace NET.W._2018.Zenovich._03.API
{
    public interface IGcd
    {
        int CalculateGcd(params int[] numbers);
        TimeSpan CompletionTime { get; }
    }
}
