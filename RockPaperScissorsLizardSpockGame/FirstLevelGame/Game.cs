using FirstLevelGame.CustomExceptions;

namespace FirstLevelGame
{
    public class Game
    {
        private readonly GameSettings _gameSettings;

        public Game(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
        }

        public Game() { }

        public void RunGame()
        {
            for (int i = 0; i < 3; i++)
            {
                InputCheck(_gameSettings.player);

                Console.WriteLine("Player:" + _gameSettings.player.Value);

                _gameSettings.computer.Value = _gameSettings.RandomMove(_gameSettings.computer);

                Console.WriteLine("Computer: " + _gameSettings.computer.Value);
                Console.WriteLine(" ");

                ScoreCount(_gameSettings.player, _gameSettings.computer);
            }

            GameResult(_gameSettings.player, _gameSettings.computer);
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
            if(string.IsNullOrEmpty(player.Value))
            {
                throw new EmptyPlayerValueException();
            }

            if(string.IsNullOrEmpty(computer.Value))
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

        public void GameResult(Player player, Player computer)
        {
            if (player.Score > computer.Score)
            {
                Console.WriteLine("Congratulations! You won this game!");
            }
            else if (player.Score == computer.Score)
            {
                Console.WriteLine("Appears to be a tie =)");
            }
            else
            {
                Console.WriteLine("Unfortunately, you have lost this game...");
            }
        }
    }
}
