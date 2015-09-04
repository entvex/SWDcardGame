public interface IPlayer
{
    string Name { get; set; }
    void AddCard(Card card);
    void ShowHand();
    int TotalValueOfHand();
}