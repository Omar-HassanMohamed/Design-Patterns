using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    interface ILogistics
    {
        void ShipProduct(string productName, string shippingAddress);
    }
}
