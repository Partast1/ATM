using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class AutomatedTellerMachine
    {
        AccountValidator accValidator = new AccountValidator();
        bool loggedIn;
        public void PinInput(Card card)
        {
           int inputPin = Convert.ToInt32(Console.ReadLine());
           loggedIn = accValidator.Validatepin(card, inputPin);
        }
        public void WithdrawFunds()
        {

        }
    }
}
