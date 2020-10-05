using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CardFactory
    {
        public Card GetCard(int pin, string name)
        {
            return new Card(pin,name);
        }
    }
}
