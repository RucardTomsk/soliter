using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Threes.Cards
{
    internal class Threes_Peaks : Threes
    {
        public Threes_Peaks() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Peaks;
            this.Image = CardResource._3_3;
        }
    }
}
