using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The Light is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("The Light is off");
        }
    }
}
