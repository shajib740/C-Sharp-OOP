using System;

namespace MethodOverridingDemo
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Start Tesla");
        }
        public override void SetClock()
        {
            Console.WriteLine("Tesla clock");
        }
    }
    interface shajib
    {
        int x;

    }
}
