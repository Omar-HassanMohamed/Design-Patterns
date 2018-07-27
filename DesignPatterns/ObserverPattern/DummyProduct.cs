using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class DummyProduct :ASubject
    {
        public void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}
