using InheritanceMiniPro.Interfaces;
using System;

namespace InheritanceMiniPro
{
    public class VehicleModel : InventoryItemModel, IPurchaseable,IRentTable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchaed");
        }
         
        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been returned");
        }
    }

}
