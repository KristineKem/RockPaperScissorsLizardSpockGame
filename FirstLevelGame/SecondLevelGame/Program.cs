namespace SecondLevelGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors, Lizard, Spock game!");
            Console.WriteLine("You will play 3 rounds with 3 players.");
            Console.WriteLine(" ");

            bool playAgain = true;
            string player;
            string choice;
            Random random = new Random();
            int playerWins = 0;
            int computerWins = 0;
            int playerScore = 0;
            List<Computer> computers = new List<Computer>
            {
                new Computer() { Name = "SHAQUILLE OATMEAL", Value = "" },
                new Computer() { Name = "OPRAH WIND FURY", Value = ""},
                new Computer() { Name = "PRINCE CHARNIMG", Value = ""}
            };

            while (playAgain)
            {
                foreach (var computer in computers)
                {
                    Console.WriteLine($"This game is with player {computer.Name}");
                    Console.WriteLine();

                    for (int i = 0; i < 3; i++)
                    {
                        player = "";
                        computer.Value = "";

                        while (player != "ROCK" && player != "PAPER" && player != "SCISSORS"
                            && player != "LIZARD" && player != "SPOCK")
                        {
                            Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                            player = Console.ReadLine();
                            player = player.ToUpper();
                        }

                        Console.WriteLine("Player:" + player);

                        switch (random.Next(1, 4))
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

                        Console.WriteLine($"{computer.Name}: {computer.Value}");
                        Console.WriteLine(" ");

                        switch (player)
                        {
                            case "ROCK":
                                if (computer.Value == "ROCK")
                                {
                                    playerWins += 0;
                                    computerWins += 0;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    playerWins += 1;
                                }
                                else
                                {
                                    computerWins += 1;
                                }
                                break;
                            case "PAPER":
                                if (computer.Value == "ROCK")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    playerWins += 0;
                                    computerWins += 0;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    computerWins += 1;
                                }
                                else
                                {
                                    playerWins += 1;
                                }
                                break;
                            case "SCISSORS":
                                if (computer.Value == "ROCK")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    playerWins += 0;
                                    computerWins += 0;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    playerWins += 1;
                                }
                                else
                                {
                                    computerWins += 1;
                                }
                                break;
                            case "LIZARD":
                                if (computer.Value == "ROCK")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    playerWins += 0;
                                    computerWins += 0;
                                }
                                else
                                {
                                    playerWins += 1;
                                }
                                break;
                            case "SPOCK":
                                if (computer.Value == "ROCK")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    computerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    computerWins += 1;
                                }
                                else
                                {
                                    playerWins += 0;
                                    computerWins += 0;
                                }
                                break;
                        }
                    }

                    if (playerWins > computerWins)
                    {
                        playerScore++;
                    }
                }

                if(playerScore == 3)
                {
                    Console.WriteLine("Congratulation! You won!");
                }
                else
                {
                    Console.WriteLine("Sorry! This time you lost...");
                }
                    
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y/N)");
                choice = Console.ReadLine();
                choice = choice.ToUpper();

                if (choice == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    public class Computer()
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }
}