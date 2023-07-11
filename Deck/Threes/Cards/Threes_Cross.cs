using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Threes.Cards
{
    internal class Threes_Cross : Threes
    {
        public Threes_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._3_2;
        }
    }
}
