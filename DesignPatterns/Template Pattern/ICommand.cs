using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Pattern
{
    public abstract class ICommand : IAlgorithm
    {
        public sealed override void Execute()
        {
            IsPowerOn();
            CheckTheStatusOfDevice();
            SwitchOnOffDevice();
        }
        /// <summary>  
        /// Shared Function  
        /// </summary>  
        /// <returns></returns>  
        private bool IsPowerOn()
        {
            Console.WriteLine("Yes, Power is on");
            return true;
        }
        /// <summary>  
        /// All base classes should have  
        /// their own implementation to check if device is on or off.  
        /// </summary>  
        protected abstract void CheckTheStatusOfDevice();
        /// <summary>  
        /// All bases classes should know how to  
        /// swithc on or off  
        /// </summary>  
        protected abstract void SwitchOnOffDevice();
    }
}
