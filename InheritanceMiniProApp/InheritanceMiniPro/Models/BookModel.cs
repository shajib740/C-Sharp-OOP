using InheritanceMiniPro.Interfaces;
using System;

namespace InheritanceMiniPro
{
    public class BookModel : InventoryItemModel , IPurchaseable
    {
        public int NumberOfPage { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased");
        }
    }

}
