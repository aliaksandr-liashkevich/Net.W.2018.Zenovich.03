using NET.W._2018.Zenovich._03.API;
using System;

namespace NET.W._2018.Zenovich._03.Model
{
    public class BinaryGcd : TimerGcd
    {
        public BinaryGcd()
        {

        }

        public BinaryGcd(ITimer timer) 
            : base(timer)
        {

        }

        protected override int ModelGcd(int[] number)
        {
            throw new NotImplementedException();
        }
    }
}
