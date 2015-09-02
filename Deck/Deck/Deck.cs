using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Deck
    {
        public List<card> Generate(int NumOfCards)
        {
            List<card> card = new List<card>();
            var random = new Random();

            for (int i = 0; i < NumOfCards; i++)
            {
                //Card colour
                var colour = random.Next(1, 4);

                //Card number
                var cardNumber = random.Next(1, 8);

                card.Add();
            }
        }
    }
}