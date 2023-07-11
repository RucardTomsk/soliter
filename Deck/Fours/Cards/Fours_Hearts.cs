using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fours.Cards
{
    internal class Fours_Hearts: Fours
    {
        public Fours_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._4_0;
        }
    }
}
