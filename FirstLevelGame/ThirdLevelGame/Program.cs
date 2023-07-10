namespace ThirdLevelGame
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

            bool playAgain = true;
            string player;
            string choice;
            Random random = new Random();
            int playerWins = 0;

            var computers = CreatePlayers(numberOfPlayers);

            while (playAgain)
            {

                foreach (var computer in computers)
                {
                    Console.WriteLine($"This game is with player {computer.Name}");
                    Console.WriteLine();

                    for (int i = 0; i < rounds; i++)
                    {
                        player = "";

                        while (player != "ROCK" && player != "PAPER" && player != "SCISSORS"
                            && player != "LIZARD" && player != "SPOCK")
                        {
                            Console.WriteLine("Enter Rock, Paper, Scissors, Lizard or Spock: ");
                            player = Console.ReadLine();
                            player = player.ToUpper();
                        }

                        Console.WriteLine("Player:" + player);

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

                        Console.WriteLine("Computer: " + computer.Value);
                        Console.WriteLine(" ");

                        switch (player)
                        {
                            case "ROCK":
                                if (computer.Value == "ROCK")
                                {
                                    playerWins += 0;
                                    computer.Score += 0;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    computer.Score += 1;
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
                                    computer.Score += 1;
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
                                    playerWins += 1;
                                }
                                break;
                            case "SCISSORS":
                                if (computer.Value == "ROCK")
                                {
                                    computer.Score += 1;
                                }
                                else if (computer.Value == "PAPER")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    playerWins += 0;
                                    computer.Score += 0;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    playerWins += 1;
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
                                    playerWins += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    computer.Score += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    playerWins += 0;
                                    computer.Score += 0;
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
                                    computer.Score += 1;
                                }
                                else if (computer.Value == "SCISSORS")
                                {
                                    playerWins += 1;
                                }
                                else if (computer.Value == "LIZARD")
                                {
                                    computer.Score += 1;
                                }
                                else
                                {
                                    playerWins += 0;
                                    computer.Score += 0;
                                }
                                break;
                        }
                    }
                }

                var playersWithScores = ScoreCount(rounds, computers);
                playersWithScores.Add(new Computer() { Name = "You", Value = "", Score = playerWins });
                var results = playersWithScores.OrderByDescending(x => x.Score).ToList();

                Console.WriteLine("Game results: ");
                foreach(var gamer in results)
                {
                    Console.WriteLine($"{gamer.Name} - {gamer.Score}");
                }

                playAgain = false;
            }

            Console.ReadKey();
        }

        public static List<Computer> CreatePlayers(int number)
        {
            List<Computer> list = new List<Computer>();

            for(int i = 1; i <= number; i++)
            {
                list.Add(new Computer() { Name = "Player" + i, Value = "", Score = 0});
            }

            return list;
        }

        public static List<Computer> ScoreCount(int rounds, List<Computer> list)
        {
            List<Computer> computers = list;
            Computer anotherComputer;
            Random random = new Random();

            foreach (var oneComputer in list)
            {
                
                for (int i = 0; i < list.Count; i++)
                {
                    anotherComputer = list[i];

                    if (oneComputer.Name != anotherComputer.Name)
                    {
                        for (int j = 0; j < rounds; j++)
                        {
                            switch (random.Next(1, 6))
                            {
                                case 1:
                                    oneComputer.Value = "ROCK";
                                    break;
                                case 2:
                                    oneComputer.Value = "PAPER";
                                    break;
                                case 3:
                                    oneComputer.Value = "SCISSORS";
                                    break;
                                case 4:
                                    oneComputer.Value = "LIZARD";
                                    break;
                                case 5:
                                    oneComputer.Value = "SPOCK";
                                    break;
                            }

                            switch (random.Next(1, 6))
                            {
                                case 1:
                                    anotherComputer.Value = "ROCK";
                                    break;
                                case 2:
                                    anotherComputer.Value = "PAPER";
                                    break;
                                case 3:
                                    anotherComputer.Value = "SCISSORS";
                                    break;
                                case 4:
                                    anotherComputer.Value = "LIZARD";
                                    break;
                                case 5:
                                    anotherComputer.Value = "SPOCK";
                                    break;
                            }

                            switch (oneComputer.Value)
                            {
                                case "ROCK":
                                    if (anotherComputer.Value == "ROCK")
                                    {
                                        oneComputer.Score += 0;
                                        anotherComputer.Score += 0;
                                    }
                                    else if (anotherComputer.Value == "PAPER")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "SCISSORS")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "LIZARD")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    break;
                                case "PAPER":
                                    if (anotherComputer.Value == "ROCK")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "PAPER")
                                    {
                                        oneComputer.Score += 0;
                                        anotherComputer.Score += 0;
                                    }
                                    else if (anotherComputer.Value == "SCISSORS")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "LIZARD")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    break;
                                case "SCISSORS":
                                    if (anotherComputer.Value == "ROCK")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "PAPER")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "SCISSORS")
                                    {
                                        oneComputer.Score += 0;
                                        anotherComputer.Score += 0;
                                    }
                                    else if (anotherComputer.Value == "LIZARD")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    break;
                                case "LIZARD":
                                    if (anotherComputer.Value == "ROCK")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "PAPER")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "SCISSORS")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "LIZARD")
                                    {
                                        oneComputer.Score += 0;
                                        anotherComputer.Score += 0;
                                    }
                                    else
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    break;
                                case "SPOCK":
                                    if (anotherComputer.Value == "ROCK")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "PAPER")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "SCISSORS")
                                    {
                                        oneComputer.Score += 1;
                                    }
                                    else if (anotherComputer.Value == "LIZARD")
                                    {
                                        anotherComputer.Score += 1;
                                    }
                                    else
                                    {
                                        oneComputer.Score += 0;
                                        anotherComputer.Score += 0;
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        anotherComputer.Score += 0;
                    }
                }
            }

            return computers;
        }
    }

    public class Computer
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int Score { get; set; }
    }
}