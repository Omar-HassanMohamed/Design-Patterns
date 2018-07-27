using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    public class InventoryManager : IInventory
    {
        public void Update(int productId)
        {
            Console.WriteLine(string.Format("Product# {0} is subtracted from the store's inventory." , productId));
       }
    }
}
