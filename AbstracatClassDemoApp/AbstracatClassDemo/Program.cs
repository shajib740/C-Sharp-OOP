using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracatClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car() { ISBN="1111", Model = "Toyota Camry 2019", Manufacturrer = "ABC Motor", NumberOfWheels =6 };
            Truck truck = new Truck() { ISBN = "2222", Model = "Toyota Corola 2023", Manufacturrer = "Shajib Motor", Length =90  };

            List<IProduct> products = new List<IProduct>();
            products.Add(truck);
            products.Add(car);

            foreach (IProduct product in products)
            {
                if (product is Car c)
                {
                    Console.WriteLine($"Car has {product.ISBN} {product.CountryOfProduction} VIN: {c.VIN}  Wheels: {c.NumberOfWheels}");
                }
                if (product is Truck t)
                {
                    Console.WriteLine($"Truck has {product.ISBN} {product.CountryOfProduction} Length: {t.Length}");

                }
            }
            Console.ReadLine();
        }
    }
    public interface IProduct
    {
        string CountryOfProduction { get; set; }
        string ISBN  { get; set; }
    }

    public abstract class Vehicle : IProduct
    {
        public string VIN { get; set; }
        public string Manufacturrer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
        public string CountryOfProduction { get; set; }
        public string ISBN { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public void PrintCarDetails()
        {
            Console.WriteLine($"Test Override");
        }
    }

    public class Truck : Vehicle
    {
        public int Length { get; set; }
        public string TruckType { get; set; }

    }
}
