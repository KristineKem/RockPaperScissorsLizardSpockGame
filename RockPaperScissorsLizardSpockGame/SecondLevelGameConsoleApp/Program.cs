using SecondLevelGame;

namespace SecondLevelGameConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors, Lizard, Spock game!");
            Console.WriteLine("You will play 3 rounds with 3 players.");
            Console.WriteLine(" ");

            bool playAgain = true;
            var game = new Game();

            while (playAgain)
            {
                var playerScore = game.RunGame();

                if (playerScore == 3)
                {
                    Console.WriteLine("Congratulation! You won!");
                }
                else
                {
                    Console.WriteLine("Sorry! This time you lost...");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y/N)");
                var choice = Console.ReadLine();
                choice = choice.ToUpper();

                playAgain = choice == "Y";

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}