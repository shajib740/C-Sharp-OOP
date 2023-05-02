using InheritanceMiniPro.Interfaces;

namespace InheritanceMiniPro
{
    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public  int  QuantityInStock { get; set; }
    }

}
