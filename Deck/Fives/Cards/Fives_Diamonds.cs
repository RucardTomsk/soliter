using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fives.Cards
{
    internal class Fives_Diamonds : Fives
    {
        public Fives_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._5_1;
        }
    }
}
