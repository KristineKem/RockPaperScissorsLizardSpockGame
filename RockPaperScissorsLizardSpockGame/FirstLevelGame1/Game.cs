namespace FirstLevelGame
{
    public class Game
    {
        private readonly GameSettings _gameSettings = new GameSettings();
        public void RunGame()
        {
            var player = new Player { Value = "", Score = 0 };
            var computer = new Player { Value = "", Score = 0 };

            for (int i = 0; i < 3; i++)
            {
                InputCheck(player);

                Console.WriteLine("Player:" + player.Value);

                computer.Value = _gameSettings.RandomMove(computer);

                Console.WriteLine("Computer: " + computer.Value);
                Console.WriteLine(" ");

                ScoreCount(player, computer);
            }

            GameResult(player, computer);
        }

        public static void InputCheck(Player player)
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
