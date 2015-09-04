using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WeakPlayer : IPlayer
{
    private List<Card> playerCards = new List<Card>();

    public WeakPlayer(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void ShowHand()
    {
        foreach (Card card in playerCards)
        {
            card.PrintCard();
        }
    }

    public int TotalValueOfHand()
    {
        int sum = 0;
        foreach (Card card in playerCards)
        {
            sum = sum + card.GetCardValue();
        }
        Console.WriteLine(this.Name + sum);
        return sum;
    }

    public void AddCard(Card card)
    {
        playerCards.Add(card);

        if (playerCards.Count > 4)
        {
            var random = new Random();
            playerCards.RemoveAt(random.Next(1, playerCards.Count));
        }
    }
}