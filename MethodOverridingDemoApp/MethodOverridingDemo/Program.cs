using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel{ 
                
                FirstName   = "Shajib",
                LastName = "Chowdhury",
                Email = "Shajib@gmail.com"
            };
            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }

    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start");
        }

        public abstract void SetClock();


        public  void StopCar()
        {
            Console.WriteLine("Turn key and stop");
        }

    }
}
