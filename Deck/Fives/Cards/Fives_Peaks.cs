using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fives.Cards
{
    internal class Fives_Peaks : Fives
    {
        public Fives_Peaks() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Peaks;
            this.Image = CardResource._5_3;
        }
    }
}
