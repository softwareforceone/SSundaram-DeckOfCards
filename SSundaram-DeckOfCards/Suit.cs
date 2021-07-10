using System.Collections.Generic;
using System.Linq;
using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public class Suit : ISuit
    {
        private IList<Card> _cards;
        public IList<Card> Cards { get => _cards; set => _cards = value; }

        private SuitType _suitType;
        public SuitType SuitType { get => _suitType; set => _suitType = value; }
        public Suit()
        {
            _cards = new List<Card>();
        }
        public int Count()
        {
            return Cards.Count();
        }

        public void InitializeSuit(SuitType suitType)
        {
            _suitType = suitType;
            Cards.Add(new Card { SuitType = suitType, FaceValue = "Ace", PointValue = 1, FaceCard = false, PositionIndexInSuit = 1 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "2", PointValue = 2, FaceCard = false, PositionIndexInSuit = 2 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "3", PointValue = 3, FaceCard = false, PositionIndexInSuit = 3 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "4", PointValue = 4, FaceCard = false, PositionIndexInSuit = 4 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "5", PointValue = 5, FaceCard = false, PositionIndexInSuit = 5 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "6", PointValue = 6, FaceCard = false, PositionIndexInSuit = 6 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "7", PointValue = 7, FaceCard = false, PositionIndexInSuit = 7 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "8", PointValue = 8, FaceCard = false, PositionIndexInSuit = 8 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "9", PointValue = 9, FaceCard = false, PositionIndexInSuit = 9 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "10", PointValue = 10, FaceCard = false, PositionIndexInSuit = 10 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "Jack", PointValue = 10, FaceCard = true, PositionIndexInSuit = 11 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "Queen", PointValue = 10, FaceCard = true, PositionIndexInSuit = 12 });
            Cards.Add(new Card { SuitType = suitType, FaceValue = "King", PointValue = 10, FaceCard = true, PositionIndexInSuit = 13 });
        }

        public int GetPositionOfCardInSuit(string FaceValue)
        {
            int PositionIndexOfCardInSuit = Cards.Where(c => c.FaceValue == FaceValue).First().PositionIndexInSuit;
            return PositionIndexOfCardInSuit;
        }
    }
}

