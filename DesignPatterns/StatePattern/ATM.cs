using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class ATM
    {
        public ATMState currentState = null;

        public ATM()
        {
            currentState = new NoCardState(1000, this);
        }

        public void StartTheATM()
        {
            while (true)
            {
                Console.WriteLine(currentState.GetNextScreen());
            }
        }
    }
}
