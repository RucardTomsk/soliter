using Soliter.Deck.Twos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Twos.Cards
{
    internal class Twos_Cross : Twos
    {
        public Twos_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._2_2;
        }
    }
}
