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
                int cardColour = random.Next(1, 4);
                Colors selectedCol = Colors.Red;
                
                switch (cardColour)
                {
                case 1:
                    selectedCol = Colors.Red;
                    break;
                case 2:
                    selectedCol = Colors.Blue;
                    break;
                case 3:
                        selectedCol = Colors.Green;
                    break;
                case 4:
                    selectedCol = Colors.Yellow;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
                //Card number
                var cardNumber = random.Next(1, 8);
                cards.Add(new Card(selectedCol,cardNumber));
            }

            return cards;
        }
    }