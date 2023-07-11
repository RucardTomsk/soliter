using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fours.Cards
{
    internal class Fours_Cross : Fours
    {
        public Fours_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._4_2;
        }
    }
}
