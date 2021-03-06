using System;
using System.Collections.Generic;

public class Player : IPlayer
{

    private List<Card> playerCards = new List<Card>();

    public Player(string name)
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
    }

}