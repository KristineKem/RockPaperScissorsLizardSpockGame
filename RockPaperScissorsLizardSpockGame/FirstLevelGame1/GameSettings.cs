namespace FirstLevelGame
{
    public class GameSettings
    {
        public string RandomMove(Player computer)
        {
            Random random = new Random();

            switch (random.Next(1, 6))
            {
                case 1:
                    computer.Value = "ROCK";
                    break;
                case 2:
                    computer.Value = "PAPER";
                    break;
                case 3:
                    computer.Value = "SCISSORS";
                    break;
                case 4:
                    computer.Value = "LIZARD";
                    break;
                case 5:
                    computer.Value = "SPOCK";
                    break;
            }

            return computer.Value;
        }

        public void ScoreCount(Player player, Player computer)
        {
            switch (player.Value)
            {
                case "ROCK":
                    if (computer.Value == "ROCK")
                    {
                        player.Score += 0;
                        computer.Score += 0;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        player.Score += 1;
                    }
                    else
                    {
                        computer.Score += 1;
                    }
                    break;
                case "PAPER":
                    if (computer.Value == "ROCK")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        player.Score += 0;
                        computer.Score += 0;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        computer.Score += 1;
                    }
                    else
                    {
                        player.Score += 1;
                    }
                    break;
                case "SCISSORS":
                    if (computer.Value == "ROCK")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        player.Score += 0;
                        computer.Score += 0;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        player.Score += 1;
                    }
                    else
                    {
                        computer.Score += 1;
                    }
                    break;
                case "LIZARD":
                    if (computer.Value == "ROCK")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        player.Score += 0;
                        computer.Score += 0;
                    }
                    else
                    {
                        player.Score += 1;
                    }
                    break;
                case "SPOCK":
                    if (computer.Value == "ROCK")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        player.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        computer.Score += 1;
                    }
                    else
                    {
                        player.Score += 0;
                        computer.Score += 0;
                    }
                    break;
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