using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fives.Cards
{
    internal class Fives_Hearts : Fives
    {
        public Fives_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._5_0;
        }
    }
}
