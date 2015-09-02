using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Deck
    {
        public List<Card.Card> Generate(int NumOfCards)
        {
            List<Card.Card> cards = new List<Card.Card>();
            var random = new Random();

            for (int i = 0; i < NumOfCards; i++)
            {
                //Card colour

                //Card number
                var cardNumber = random.Next(1, 8);

                cards
            }

            return cards;
        }
    }