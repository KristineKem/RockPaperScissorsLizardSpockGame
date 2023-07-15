namespace ThirdLevelGameConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock game!");
            Console.Write("Choose number of players (1-9): ");
            var numberOfPlayers = int.Parse(Console.ReadLine());
            Console.Write("Choose number of round with one player (1-5): ");
            var rounds = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"You will play with {numberOfPlayers} players and have {rounds} rounds with each of them.");
            Console.WriteLine();

            var game = new Game();
            game.RunGame(numberOfPlayers, rounds);

            Console.ReadKey();
        }
    }
}