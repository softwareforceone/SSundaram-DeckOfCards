using System;
using System.Collections.Generic;
using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public interface ISuit
    {
        IList<Card> Cards { get; set; }
        int Count();
        
        void InitializeSuit(SuitType suitType);
        int GetPositionOfCardInSuit(string FaceValue);
    }
}
