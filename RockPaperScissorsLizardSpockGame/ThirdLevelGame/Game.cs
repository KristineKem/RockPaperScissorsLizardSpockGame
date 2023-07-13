﻿namespace ThirdLevelGame
{
    public class Game
    {
        private static readonly GameSettings GameOption = new GameSettings();

        public void RunGame(int numberOfPlayers, int rounds)
        {
            bool playAgain = true;
            var you = new Player { Name = "You", Value = "", Score = 0 };

            var players = CreatePlayers(numberOfPlayers);

            while (playAgain)
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"This game is with player {player.Name}");
                    Console.WriteLine();

                    for (int i = 0; i < rounds; i++)
                    {
                        you.Value = "";

                        while (you.Value != "ROCK" && you.Value != "PAPER" && you.Value != "SCISSORS"
                               && you.Value != "LIZARD" && you.Value != "SPOCK")
                        {
                            Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                            you.Value = Console.ReadLine();
                            you.Value = you.Value.ToUpper();
                        }

                        Console.WriteLine("You:" + you.Value);

                        player.Value = GameOption.RandomMove(player);

                        Console.WriteLine("Computer: " + player.Value);
                        Console.WriteLine(" ");


                        GameOption.YouVsComputerScore(you, player);
                    }
                }

                var playersWithScores = ScoreCount(rounds, players);
                playersWithScores.Add(you);
                var results = playersWithScores.OrderByDescending(x => x.Score).ToList();

                Console.WriteLine("Game results: ");
                foreach (var gamer in results)
                {
                    Console.WriteLine($"{gamer.Name} - {gamer.Score}");
                }

                playAgain = false;
            }
        }

        public List<Player> CreatePlayers(int number)
        {
            List<Player> list = new List<Player>();

            for (int i = 1; i <= number; i++)
            {
                list.Add(new Player { Name = "Player" + i, Value = "", Score = 0 });
            }

            return list;
        }

        public List<Player> ScoreCount(int rounds, List<Player> list)
        {
            List<Player> players = list;

            for (int i = 0; i < list.Count - 1; i++)
            {
                Player firstPlayer = list[i];

                for (int k = 0; k < list.Count; k++)
                {
                    if (k < list.Count)
                    {
                        Player secondPlayer = list[k + i];

                        if (firstPlayer.Name != secondPlayer.Name)
                        {
                            for (int j = 0; j < rounds; j++)
                            {
                                GameOption.ComputerVsComputerScore(firstPlayer, secondPlayer);
                            }
                        }
                        else
                        {
                            secondPlayer.Score += 0;
                        }
                    }
                }
            }

            return players;
        }
    }
}