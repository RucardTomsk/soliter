using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Twos.Cards
{
    internal class Twos_Diamonds : Twos
    {
        public Twos_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._2_1;
        }
    }
}
