using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceMiniPro.Interfaces;

namespace InheritanceMiniPro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<IRentTable> rentTables = new List<IRentTable>();
            List<IPurchaseable> purchaseables = new List<IPurchaseable>();
          
            var excavator = new ExcavatorModel { ProductName = "CAT", QuantityInStock = 10 };
            var vehicle = new VehicleModel { ProductName = "Toyota Camry", QuantityInStock = 8 };
            var book = new BookModel { ProductName = " Life in DownTown", NumberOfPage = 302, QuantityInStock = 109 };
            
            rentTables.Add(vehicle);
            rentTables.Add(excavator);

            purchaseables.Add(vehicle);
            purchaseables.Add(book);

            Console.Write("Rent /Purchase ? : ");
            string decision = Console.ReadLine();

            if (decision.ToLower() == "rent" )
            {
                foreach (IRentTable item in rentTables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                    Console.Write("Do you want to return this item (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (IPurchaseable item in purchaseables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.ReadLine();
        }
    }

}
