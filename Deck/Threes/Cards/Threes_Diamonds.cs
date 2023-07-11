using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Threes.Cards
{
    internal class Threes_Diamonds : Threes
    {
        public Threes_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._3_1;
        }
    }
}
