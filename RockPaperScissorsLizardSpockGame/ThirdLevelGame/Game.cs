using ThirdLevelGame.CustomExceptions;

namespace ThirdLevelGame
{
    public class Game
    {
        private readonly GameSettings _gameSettings = new GameSettings();

        public void RunGame(int numberOfPlayers, int rounds)
        {
            bool playAgain = true;
            
            var players = _gameSettings.CreatePlayers(numberOfPlayers);

            while (playAgain)
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"This game is with player {player.Name}");
                    Console.WriteLine();

                    for (int i = 0; i < rounds; i++)
                    {
                        InputCheck(_gameSettings.you);

                        Console.WriteLine("You:" + _gameSettings.you.Value);

                        player.Value = _gameSettings.RandomMove(player);

                        Console.WriteLine("Computer: " + player.Value);
                        Console.WriteLine(" ");

                        YouVsComputerScore(_gameSettings.you, player);
                    }
                }

                var playersWithScores = ScoreCount(rounds, players);
                playersWithScores.Add(_gameSettings.you);
                var results = playersWithScores.OrderByDescending(x => x.Score).ToList();

                GameResult(results);

                playAgain = false;
            }
        }

        public void ComputerVsComputerScore(Player firstPlayer, Player secondPlayer)
        {
            if (firstPlayer.Value.Equals(secondPlayer.Value))
            {
                firstPlayer.Score += 0;
                secondPlayer.Score += 0;
            }
            else if (_gameSettings.moves[firstPlayer.Value].Contains(secondPlayer.Value))
            {
                firstPlayer.Score += 1;
            }
            else
            {
                secondPlayer.Score += 1;
            }
        }

        public void YouVsComputerScore(Player you, Player computer)
        {
            if (_gameSettings.moves[you.Value].Contains(computer.Value))
            {
                you.Score += 1;
            }
            else
            {
                computer.Score += 1;
            }
        }

        public List<Player> ScoreCount(int rounds, List<Player> list)
        {
            if (rounds <= 0)
            {
                throw new ZeroRoundsException();
            }

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
                                _gameSettings.RandomMove(firstPlayer);
                                _gameSettings.RandomMove(secondPlayer);

                                ComputerVsComputerScore(firstPlayer, secondPlayer);
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

        public void InputCheck(Player player)
        {
            player.Value = "";

            while (player.Value != "ROCK" && player.Value != "PAPER" && player.Value != "SCISSORS"
                   && player.Value != "LIZARD" && player.Value != "SPOCK")
            {
                Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                player.Value = Console.ReadLine();
                player.Value = player.Value.ToUpper();
            }
        }

        public void GameResult(List<Player> list)
        {
            Console.WriteLine("Game results: ");
            foreach (var gamer in list)
            {
                Console.WriteLine($"{gamer.Name} - {gamer.Score}");
            }
        }
    }
}
