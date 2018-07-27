using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Pattern
{
    public class SwitchOnWaschmachine : ICommand
    {
        private readonly Washmachine _waschmachine;
        private bool isDeviceOn
        {
            get;
            set;
        }
        public SwitchOnWaschmachine(Washmachine washmachine)
        {
            _waschmachine = washmachine;
        }
        protected override void CheckTheStatusOfDevice()
        {
            if (isDeviceOn)
                Console.WriteLine("Device is Already On");

            else
                Console.WriteLine("Device is Already Off");
            
        }
        protected override void SwitchOnOffDevice()
        {
            if (isDeviceOn)
            {
                _waschmachine.SwitchOff();
                Console.WriteLine("Device is Already Off");
            }
            else
            {
                _waschmachine.SwitchOn();
                Console.WriteLine("Device is Already On");
            }
        }
    }
}
