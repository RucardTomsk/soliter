using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Twos.Cards
{
    internal class Twos_Hearts : Twos
    {
        public Twos_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._2_0;
        }
    }
}
