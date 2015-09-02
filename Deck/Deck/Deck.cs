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

    class Game
    {
        List<player> players = new List<player>();
        public bool IsGameStarted { get; private set; }

        public AddPlayer()
        {
            throw new NotImplementedException();
        }

        public StartGame()
        {
            Console.WriteLine("Welcome to the awesome card game!");
            throw new NotImplementedException();
        }

        public dealCards()
        {
            throw new NotImplementedException();
        }

        private string AnnounceWinner(player winner)
        {
            Console.WriteLine("{0} has won the game!!!!", player.Name);
        }
    }

}