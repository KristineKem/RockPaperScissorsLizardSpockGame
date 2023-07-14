using FirstLevelGame;

namespace FirstLevelGameConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors, Lizard, Spock game!");
            Console.WriteLine("We will play 3 times to get the winner.");
            Console.WriteLine(" ");

            bool playAgain = true;
            string choice;
            var game = new Game();
            
            while (playAgain)
            {
                game.RunGame();

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