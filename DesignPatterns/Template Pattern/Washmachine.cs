using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Pattern
{
    public class Washmachine
    {
        public bool _deviceStatus
        {
            get;
            private set;
        }
        internal void SwitchOn()
        {
            _deviceStatus = true;
        }
        internal void SwitchOff()
        {
            _deviceStatus = false;
        }
    }
}
