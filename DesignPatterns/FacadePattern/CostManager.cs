using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    public class CostManager :ICosting
    {
        public float ApplyDiscounts(float price, float discountPercent)
        {
            Console.WriteLine(string.Format("A discount of {0}% has been applied on the product's price of {1}", discountPercent,price));            
      return price - ((discountPercent / 100) * price);
        }
    }
}
