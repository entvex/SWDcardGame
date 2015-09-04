using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Game
{
    List<Player> players = new List<Player>();
    Deck deck = new Deck();

    public Game()
    {
        Player David = new Player("David");
        Player Kasper = new Player("Kasper");
        Player Kristian = new Player("Kristian");

        AddPlayer(David);
        AddPlayer(Kasper);
        AddPlayer(Kristian);

        StartGame();
    }

    public bool IsGameStarted { get; private set; }

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to the awesome card game!");

        DealCards(5);

        for (int i = 0; i < players.Count; i++)
        {
            Console.WriteLine("My name is {0} and i have thease cards", players[i].Name);
            players[i].ShowHand();
        }

        Player winner = new Player("dad");
        int currentWinner = 0;

        for (int i = 0; i < players.Count; i++)
        {
            if (players[i].TotalValueOfHand() >= currentWinner)
            {
                winner = players[i];
            }

        }

        AnnounceWinner(winner);

    }

    public void DealCards(int cards)
    {
        for (int i = 0; i < cards; i++)
        {
            foreach (var player in players)
            {
                player.AddCard(deck.Generate(1)[0]);
            }
        }
    }

    private void AnnounceWinner(Player winner)
    {
        Console.WriteLine("{0} has won the game!!!!", winner.Name);
    }
}