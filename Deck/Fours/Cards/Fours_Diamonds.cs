using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fours.Cards
{
    internal class Fours_Diamonds : Fours
    {
        public Fours_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._4_1;
        }
    }
}
