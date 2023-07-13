namespace SecondLevelGame
{
    public class Game
    {
        private readonly GameSettings _gameSettings = new GameSettings();

        public int RunGame()
        {
            var playerScore = 0;
            var player = new Player { Name = "You", Value = "", Score = 0 };

            List<Player> computers = new List<Player>
            {
                new Player { Name = "SHAQUILLE OATMEAL", Value = "" },
                new Player { Name = "OPRAH WIND FURY", Value = "" },
                new Player { Name = "PRINCE CHARMING", Value = "" }
            };

            foreach (var computer in computers)
            {
                Console.WriteLine($"This game is with player {computer.Name}");
                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    player.Value = "";
                    computer.Value = "";

                    while (player.Value != "ROCK" && player.Value != "PAPER" && player.Value != "SCISSORS"
                           && player.Value != "LIZARD" && player.Value != "SPOCK")
                    {
                        Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                        player.Value = Console.ReadLine();
                        player.Value = player.Value.ToUpper();
                    }

                    Console.WriteLine("You:" + player.Value);

                    computer.Value = _gameSettings.RandomMove(computer);

                    Console.WriteLine($"{computer.Name}: {computer.Value}");
                    Console.WriteLine(" ");

                    _gameSettings.ScoreCount(player, computer);

                    if (player.Score > computer.Score)
                    {
                        playerScore++;
                    }
                }
            }

            return playerScore;
        }
    }
}
