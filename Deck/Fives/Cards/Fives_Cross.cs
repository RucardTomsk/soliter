using Soliter.Deck.Twos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Fives.Cards
{
    internal class Fives_Cross : Fives
    {
        public Fives_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._5_2;
        }
    }
}
