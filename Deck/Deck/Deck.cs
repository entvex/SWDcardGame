using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Deck
{
    public List<Card> Generate(int numOfCards)
    {
        List<Card> cards = new List<Card>();
        var random = new Random();

        for (int i = 0; i < numOfCards; i++)
        {
            //Card colour
            Colors cardColour = (Colors)random.Next(1, Enum.GetNames(typeof(Colors)).Length);

            //Card number
            var cardNumber = random.Next(1, 8);
            cards.Add(new Card(cardColour, cardNumber));
        }

        return cards;
    }
}