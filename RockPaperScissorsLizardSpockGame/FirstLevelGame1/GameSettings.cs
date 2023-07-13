namespace FirstLevelGame1
{
    public class GameSettings
    {
        public string RandomMove(string computer)
        {
            Random random = new Random();

            switch (random.Next(1, 6))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
                case 4:
                    computer = "LIZARD";
                    break;
                case 5:
                    computer = "SPOCK";
                    break;
            }

            return computer;
        }

        public void ScoreCount(string player, string computer)
        {

        }
    }
}