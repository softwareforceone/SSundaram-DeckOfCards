using System;
using System.Collections.Generic;
using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public interface IDeck
    {
        void InitializeDeck();
        Dictionary<string, Suit> Suits { get; set; }
        int CountCardsInDeck();
        List<string> GetSuitsPresentInDeck();
        List<Card> GetCardsBySuitInDeck(SuitType suitType);
        int GetPointValueByFaceValueBySuit(string FaceValue, SuitType suitType);
    }
}
