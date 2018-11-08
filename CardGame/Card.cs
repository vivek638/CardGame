using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    class Card
    {
        private string face;
        private string suit;

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return face + "of" + suit;
        }
    }
}
