namespace FirstLevelGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors, Lizard, Spock game!");
            Console.WriteLine("We will play 3 times to get the winner.");
            Console.WriteLine(" ");

            bool playAgain = true;
            string player;
            string computer;
            string choice;
            
            int playerWins = 0;
            int computerWins = 0;

            while (playAgain)
            {
                for (int i = 0; i < 3; i++)
                {
                    player = "";
                    computer = "";

                    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS"
                        && player != "LIZARD" && player != "SPOCK")
                    {
                        Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                        player = Console.ReadLine();
                        player = player.ToUpper();
                    }

                    Console.WriteLine("Player:" + player);

                    

                    Console.WriteLine("Computer: " + computer);
                    Console.WriteLine(" ");

                    switch (player)
                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                playerWins += 0;
                                computerWins += 0;
                            }
                            else if (computer == "PAPER")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "SCISSORS")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "LIZARD")
                            {
                                playerWins += 1;
                            }
                            else
                            {
                                computerWins += 1;
                            }
                            break;
                        case "PAPER":
                            if (computer == "ROCK")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "PAPER")
                            {
                                playerWins += 0;
                                computerWins += 0;
                            }
                            else if (computer == "SCISSORS")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "LIZARD")
                            {
                                computerWins += 1;
                            }
                            else
                            {
                                playerWins += 1;
                            }
                            break;
                        case "SCISSORS":
                            if (computer == "ROCK")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "PAPER")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "SCISSORS")
                            {
                                playerWins += 0;
                                computerWins += 0;
                            }
                            else if (computer == "LIZARD")
                            {
                                playerWins += 1;
                            }
                            else
                            {
                                computerWins += 1;
                            }
                            break;
                        case "LIZARD":
                            if (computer == "ROCK")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "PAPER")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "SCISSORS")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "LIZARD")
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
                            if (computer == "ROCK")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "PAPER")
                            {
                                computerWins += 1;
                            }
                            else if (computer == "SCISSORS")
                            {
                                playerWins += 1;
                            }
                            else if (computer == "LIZARD")
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
                    Console.WriteLine("Congratulations! You won this game!");
                }
                else
                {
                    Console.WriteLine("Unfortunately, you have lost this game...");
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
}