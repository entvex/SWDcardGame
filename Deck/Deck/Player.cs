public class Player
{

    private List<Card> playerCards;

    public Player(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void ShowHand()
    {
        foreach (Card card in playerCards)
        {
            Console.WriteLine(card.printcard());
        }
    }

    public int TotalValueOfHand()
    {
        int sum = 0;
        foreach (Card card in playerCards)
        {
            sum += card.GetCardValue();
        }
        return sum;
    }

    public void AddCard(Card card)
    {
        playerCards.Add(card);
    }

}