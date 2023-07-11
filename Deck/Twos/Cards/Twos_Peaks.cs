using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Twos.Cards
{
    internal class Twos_Peaks : Twos
    {
        public Twos_Peaks() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Peaks;
            this.Image = CardResource._2_3;
        }
    }
}
