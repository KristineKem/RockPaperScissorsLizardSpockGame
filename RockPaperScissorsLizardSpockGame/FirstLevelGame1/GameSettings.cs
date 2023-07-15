namespace FirstLevelGame
{
    public class GameSettings
    {
        private readonly string[] _choices = { "ROCK", "SCISSORS", "PAPER", "LIZARD", "SPOCK" };

        public readonly Dictionary<string, string> moves = new()
        {
            { "ROCK", "SCISSORS, LIZARD" },
            { "SCISSORS", "PAPER, LIZARD" },
            { "PAPER", "ROCK, SPOCK" },
            { "LIZARD", "SPOCK, PAPER" },
            { "SPOCK", "SCISSORS, ROCK" }
        };

        public string RandomMove(Player computer)
        {
            Random random = new Random();

            computer.Value = _choices[random.Next(_choices.Length)];

            return computer.Value;
        }
    }
}