using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NoStateATM_spagetti
    {
        private MACHINE_STATE currentMachineState = MACHINE_STATE.NO_CARD;
        private int dummyCashPresent = 1000;

        public string GetNextScreen()
        {
            switch (currentMachineState)
            {
                case MACHINE_STATE.NO_CARD:
                    // Here we will get the pin validated
                    return GetPinValidated();
                case MACHINE_STATE.CARD_VALIDATED:
                    // Lets try to withdraw the money
                    return WithdrawMoney();
                case MACHINE_STATE.CASH_WITHDRAWN:
                    // Lets let the user go now
                    return SayGoodBye();
                default:
                    return string.Empty;
            }
        }

        private string SayGoodBye()
        {
            currentMachineState = MACHINE_STATE.NO_CARD;
            return string.Format("Thanks you for using us, Amount left in ATM: {0}", dummyCashPresent.ToString());
        }

        private string WithdrawMoney()
        {
            string userInput = Console.ReadLine();

            int requestAmount;
            bool result = Int32.TryParse(userInput, out requestAmount);

            if (result == true)
            {
                if (dummyCashPresent < requestAmount)
                {
                    // Show only message and no change in state
                    return "Amount not present";
                }

                dummyCashPresent -= requestAmount;
                currentMachineState = MACHINE_STATE.CASH_WITHDRAWN;
            }
                return string.Format(@"Amount of {0} has been withdrawn. Press Enter to proceed", requestAmount);
        }
        private string GetPinValidated()
        {
            Console.WriteLine("Please Enter your Pin");
            string userInput = Console.ReadLine();

            // lets check with the dummy pin
            if (userInput.Trim() == "1234")
            {
                currentMachineState = MACHINE_STATE.CARD_VALIDATED;
                return "Enter the Amount to Withdraw";
            }

            // Show only message and no change in state
            return "Invalid PIN";
        }
    }
}
