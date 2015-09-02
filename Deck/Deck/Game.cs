using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
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
