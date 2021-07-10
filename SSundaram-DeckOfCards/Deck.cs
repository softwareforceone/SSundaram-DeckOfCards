using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public class Deck : IDeck
    {
        private Dictionary<string, Suit> _suits;
        Dictionary<string, Suit> IDeck.Suits { get => _suits; set => _suits = value; }

        Suit Hearts;
        Suit Clubs;
        Suit Spades;
        Suit Diamonds;

        public Deck()
        {
            _suits = new Dictionary<string, Suit>();
            Hearts = new Suit();
            Clubs = new Suit();
            Spades = new Suit();
            Diamonds = new Suit();
        }

        public void InitializeDeck()
        {
            Hearts.InitializeSuit(SuitTypeEnum.SuitType.Hearts);
            Clubs.InitializeSuit(SuitTypeEnum.SuitType.Clubs);
            Spades.InitializeSuit(SuitTypeEnum.SuitType.Spades);
            Diamonds.InitializeSuit(SuitTypeEnum.SuitType.Diamonds);

            _suits.Add("Hearts", Hearts);
            _suits.Add("Clubs", Clubs);
            _suits.Add("Spades", Spades);
            _suits.Add("Diamonds", Diamonds);
        }

        //Scenario 1
        public int CountCardsInDeck()
        {
            int TotalCardsInDeck = Hearts.Count() + Clubs.Count() + Spades.Count() + Diamonds.Count();
            return TotalCardsInDeck;
        }
        //Scenario 2
        public List<string> GetSuitsPresentInDeck()
        {
            List<string> SuitsInDeck = new List<string>();

            foreach (KeyValuePair<string, Suit> entry in _suits)
            {
                if (!SuitsInDeck.Contains(entry.Key))
                {
                    SuitsInDeck.Add(entry.Key);
                }
            }
            return SuitsInDeck;
        }
        //Scenario 3
        public List<Card> GetCardsBySuitInDeck(SuitType suitType)
        {
            List<Card> cardsInSuit = new List<Card>();
            Suit result;

            if (_suits.ContainsKey(suitType.ToString()))
            {
                if (_suits.TryGetValue(suitType.ToString(), out result))
                {
                    foreach (Card card in result.Cards)
                    {
                        cardsInSuit.Add(card);
                    }
                }
                else
                {
                    return cardsInSuit;
                }
            }
            return cardsInSuit;
        }

        //Scenario 4
        public int GetPointValueByFaceValueBySuit(string FaceValue, SuitType suitType)
        {
            int pointValue = 0;
            Suit result = null;

            if (_suits.ContainsKey(suitType.ToString()))
            {
                if (_suits.TryGetValue(suitType.ToString(), out result))
                {
                    pointValue = result.Cards.Where(c => c.FaceValue == FaceValue).First().PointValue;
                }
                else
                {
                    pointValue = 0;
                }
            }
            return pointValue;
        }

        //Scenario 5
        public int GetPositionOfCardBySuit(string FaceValue, SuitType suitType)
        {
            int pointValue = 0;
            Suit result = null;

            if (_suits.ContainsKey(suitType.ToString()))
            {
                if (_suits.TryGetValue(suitType.ToString(), out result))
                {
                    pointValue = result.Cards.Where(c => c.FaceValue == FaceValue).First().PositionIndexInSuit;
                }
                else
                {
                    pointValue = 0;
                }
            }
            return pointValue;
        }

     
    }
}
