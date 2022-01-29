using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Card
    {

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
        public string Suit { get; private set; } // H, D, S, C
        public string Value { get; private set; } // 2, 3, 4, ..... Q, K, A
        // todo crate a card

    }
}
