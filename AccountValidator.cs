using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class AccountValidator
    {
       public bool Validatepin(Card card,int input)
        {
            if (card.PinCode == input)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
