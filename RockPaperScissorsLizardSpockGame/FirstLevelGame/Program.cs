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

            var playAgain = true;
            
            var game = new Game();
            
            while (playAgain)
            {
                game.RunGame();

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