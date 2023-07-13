namespace ThirdLevelGame
{
    public class GameSettings
    {
        public string RandomMove(Player player)
        {
            Random random = new Random();

            switch (random.Next(1, 6))
            {
                case 1:
                    player.Value = "ROCK";
                    break;
                case 2:
                    player.Value = "PAPER";
                    break;
                case 3:
                    player.Value = "SCISSORS";
                    break;
                case 4:
                    player.Value = "LIZARD";
                    break;
                case 5:
                    player.Value = "SPOCK";
                    break;
            }

            return player.Value;
        }

        public void ComputerVsComputerScore(Player firstPlayer, Player secondPlayer)
        {
            var firstPlayerMove = RandomMove(firstPlayer);
            var secondPlayerMove = RandomMove(secondPlayer);
                        
            switch (firstPlayerMove)
            {
                case "ROCK":
                    if (secondPlayerMove == "ROCK")
                    {
                        firstPlayer.Score += 0;
                        secondPlayer.Score += 0;
                    }
                    else if (secondPlayerMove == "PAPER")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "SCISSORS")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "LIZARD")
                    {
                        firstPlayer.Score += 1;
                    }
                    else
                    {
                        secondPlayer.Score += 1;
                    }
                    break;
                case "PAPER":
                    if (secondPlayerMove == "ROCK")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "PAPER")
                    {
                        firstPlayer.Score += 0;
                        secondPlayer.Score += 0;
                    }
                    else if (secondPlayerMove == "SCISSORS")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "LIZARD")
                    {
                        secondPlayer.Score += 1;
                    }
                    else
                    {
                        firstPlayer.Score += 1;
                    }
                    break;
                case "SCISSORS":
                    if (secondPlayerMove == "ROCK")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "PAPER")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "SCISSORS")
                    {
                        firstPlayer.Score += 0;
                        secondPlayer.Score += 0;
                    }
                    else if (secondPlayerMove == "LIZARD")
                    {
                        firstPlayer.Score += 1;
                    }
                    else
                    {
                        secondPlayer.Score += 1;
                    }
                    break;
                case "LIZARD":
                    if (secondPlayerMove == "ROCK")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "PAPER")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "SCISSORS")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "LIZARD")
                    {
                        firstPlayer.Score += 0;
                        secondPlayer.Score += 0;
                    }
                    else
                    {
                        firstPlayer.Score += 1;
                    }
                    break;
                case "SPOCK":
                    if (secondPlayerMove == "ROCK")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "PAPER")
                    {
                        secondPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "SCISSORS")
                    {
                        firstPlayer.Score += 1;
                    }
                    else if (secondPlayerMove == "LIZARD")
                    {
                        secondPlayer.Score += 1;
                    }
                    else
                    {
                        firstPlayer.Score += 0;
                        secondPlayer.Score += 0;
                    }
                    break;
            }
        }

        public void YouVsComputerScore(Player you, Player computer)
        {
            switch (you.Value)
            {
                case "ROCK":
                    if (computer.Value == "ROCK")
                    {
                        you.Score += 0;
                        computer.Score += 0;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        you.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        you.Score += 1;
                    }
                    else
                    {
                        computer.Score += 1;
                    }
                    break;
                case "PAPER":
                    if (computer.Value == "ROCK")
                    {
                        you.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        you.Score += 0;
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
                        you.Score += 1;
                    }
                    break;
                case "SCISSORS":
                    if (computer.Value == "ROCK")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        you.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        you.Score += 0;
                        computer.Score += 0;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        you.Score += 1;
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
                        you.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        you.Score += 0;
                        computer.Score += 0;
                    }
                    else
                    {
                        you.Score += 1;
                    }
                    break;
                case "SPOCK":
                    if (computer.Value == "ROCK")
                    {
                        you.Score += 1;
                    }
                    else if (computer.Value == "PAPER")
                    {
                        computer.Score += 1;
                    }
                    else if (computer.Value == "SCISSORS")
                    {
                        you.Score += 1;
                    }
                    else if (computer.Value == "LIZARD")
                    {
                        computer.Score += 1;
                    }
                    else
                    {
                        you.Score += 0;
                        computer.Score += 0;
                    }
                    break;
            }
        }
    }
}
