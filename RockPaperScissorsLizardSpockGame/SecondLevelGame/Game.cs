using SecondLevelGame.CustomExceptions;

namespace SecondLevelGame
{
    public class Game
    {
        private readonly GameSettings _gameSettings = new GameSettings();

        public int RunGame()
        {
            var playerScore = 0;
            
            foreach (var computer in _gameSettings.computers)
            {
                Console.WriteLine($"This game is with player {computer.Name}");
                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    InputCheck(_gameSettings.player);

                    Console.WriteLine("You:" + _gameSettings.player.Value);

                    computer.Value = _gameSettings.RandomMove(computer);

                    Console.WriteLine($"{computer.Name}: {computer.Value}");
                    Console.WriteLine(" ");

                    ScoreCount(_gameSettings.player, computer);

                    if (_gameSettings.player.Score > computer.Score)
                    {
                        playerScore++;
                    }
                }
            }

            return playerScore;
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

        public void ScoreCount(Player player, Player computer)
        {
            if (string.IsNullOrEmpty(player.Value))
            {
                throw new EmptyPlayerValueException();
            }

            if (string.IsNullOrEmpty(computer.Value))
            {
                throw new EmptyComputerValueException();
            }

            if (_gameSettings.moves[player.Value].Contains(computer.Value))
            {
                player.Score += 1;
            }
            else
            {
                computer.Score += 1;
            }
        }
    }
}
