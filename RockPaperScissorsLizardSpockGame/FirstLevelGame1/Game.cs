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

                _gameSettings.ScoreCount(player, computer);
            }

            _gameSettings.GameResult(player, computer);
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
    }
}
