using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
   public  class Card
    {
        private int pinCode;
        private string cardsName ;
        private Account account;

        public string CardsName 
        {
            get { return cardsName; }
            set { cardsName = value; }
        }


        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }
        public Card(int pinCode, string cardsName)
        {
            PinCode = pinCode;
            CardsName = cardsName;
        }

    }
}
