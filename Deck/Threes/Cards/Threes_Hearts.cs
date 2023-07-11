using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Threes.Cards
{
    internal class Threes_Hearts : Threes
    {
        public Threes_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._3_0;
        }
    }
}
