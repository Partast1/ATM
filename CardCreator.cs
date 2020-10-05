using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
   public class CardCreator
    {
        public Card card;
        CardFactory cf = new CardFactory();
        public CardCreator()
        {
            card = cf.GetCard(1234, "Jens");
        }
     

    }
}
