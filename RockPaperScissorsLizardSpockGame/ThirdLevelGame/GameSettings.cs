namespace ThirdLevelGame
{
    public class GameSettings
    {
        public Player you = new Player { Name = "You", Value = "", Score = 0 };

        private readonly string[] _choices = { "ROCK", "SCISSORS", "PAPER", "LIZARD", "SPOCK" };

        public readonly Dictionary<string, string> moves = new()
        {
            { "ROCK", "SCISSORS, LIZARD" },
            { "SCISSORS", "PAPER, LIZARD" },
            { "PAPER", "ROCK, SPOCK" },
            { "LIZARD", "SPOCK, PAPER" },
            { "SPOCK", "SCISSORS, ROCK" }
        };

        public string RandomMove(Player player)
        {
            Random random = new Random();

            player.Value = _choices[random.Next(_choices.Length)];

            return player.Value;
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
    }
}
