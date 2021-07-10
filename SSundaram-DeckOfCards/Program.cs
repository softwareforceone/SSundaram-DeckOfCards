using System;
using System.Text;
using System.Collections.Generic;
using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.InitializeDeck();
        }
    }
}