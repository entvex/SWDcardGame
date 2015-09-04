using System;

public enum Colors
{
    Red = 1,
    Blue = 2,
    Green = 3,
    Yellow = 4,
    Gold = 5
}

public class Card
{
    public Card(Colors col, int No)
    {
        CardCol = col;
        CardNo = No;
    }

    public Colors CardCol { get; }
    private int CardNo { get; }


    public int GetCardValue()
    {
        return (int) CardCol*CardNo;
    }

    public void PrintCard()
    {
        Console.WriteLine(CardCol + " " + CardNo);
    }
}