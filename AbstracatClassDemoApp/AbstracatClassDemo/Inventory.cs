using System;

namespace AbstracatClassDemo
{
    public abstract class Inventory
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; } 

        public void PrintDetails()
        {
            Console.WriteLine($"{ProductName} on hand {QuantityOnHand}");
        }
    }
}
