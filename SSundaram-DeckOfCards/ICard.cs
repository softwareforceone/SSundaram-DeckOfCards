using static SSundaram_DeckOfCards.SuitTypeEnum;

namespace SSundaram_DeckOfCards
{
    public interface ICard
    {
        SuitType SuitType { get; set; }
        string FaceValue { get; set; }
        int PointValue { get; set; }
        bool FaceCard { get; set; }
        int PositionIndexInSuit { get; set; }
    }
}
