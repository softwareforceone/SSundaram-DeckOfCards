using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public class Card : ICard
    {
        public SuitType SuitType { get; set; }
        public string FaceValue { get; set; }
        public int PointValue { get; set; }
        public bool FaceCard { get; set; }
        public int PositionIndexInSuit { get; set; }
    }
}
