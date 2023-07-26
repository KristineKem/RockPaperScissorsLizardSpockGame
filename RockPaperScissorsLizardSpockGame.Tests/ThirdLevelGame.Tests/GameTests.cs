using FluentAssertions;
using ThirdLevelGame.CustomExceptions;

namespace ThirdLevelGame.Tests
{
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void InputCheck_ShouldSetValidInput_ReturnRock()
        {
            Player player = new Player();
            var input = "rock";
            StringReader inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            _game.InputCheck(player);

            player.Value.Should().Be("ROCK");
        }

        [Test]
        public void InputCheck_ShouldSetValidInput_ReturnPaper()
        {
            Player player = new Player();
            var input = "paper";
            StringReader inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            _game.InputCheck(player);

            player.Value.Should().Be("PAPER");
        }

        [Test]
        public void InputCheck_ShouldSetValidInput_ReturnScissors()
        {
            Player player = new Player();
            var input = "scissors";
            StringReader inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            _game.InputCheck(player);

            player.Value.Should().Be("SCISSORS");
        }

        [Test]
        public void InputCheck_ShouldSetValidInput_ReturnLizard()
        {
            Player player = new Player();
            var input = "lizard";
            StringReader inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            _game.InputCheck(player);

            player.Value.Should().Be("LIZARD");
        }

        [Test]
        public void InputCheck_ShouldSetValidInput_ReturnSpock()
        {
            Player player = new Player();
            var input = "spock";
            StringReader inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            _game.InputCheck(player);

            player.Value.Should().Be("SPOCK");
        }

        [Test]
        public void ComputerVsComputerScore_FirstComputerShouldGetPoint_ReturnsFirstComputerScoreOne()
        {
            Player firstComputer = new Player { Value = "ROCK", Score = 0 };
            Player secondComputer = new Player { Value = "LIZARD", Score = 0 };

            _game.ComputerVsComputerScore(firstComputer, secondComputer);

            firstComputer.Score.Should().Be(1);
        }

        [Test]
        public void ComputerVsComputerScore_SecondComputerShouldGetPoint_ReturnsSecondComputerScoreOne()
        {
            Player firstComputer = new Player { Value = "PAPER", Score = 0 };
            Player secondComputer = new Player { Value = "SCISSORS", Score = 0 };

            _game.ComputerVsComputerScore(firstComputer, secondComputer);

            secondComputer.Score.Should().Be(1);
        }

        [Test]
        public void ComputerVsComputerScore_GameIsATie_ReturnsBothPlayersScoreZero()
        {
            Player firstComputer = new Player { Value = "LIZARD", Score = 0 };
            Player secondComputer = new Player { Value = "LIZARD", Score = 0 };

            _game.ComputerVsComputerScore(firstComputer, secondComputer);

            firstComputer.Score.Should().Be(0);
            secondComputer.Score.Should().Be(0);
        }

        [Test]
        public void YouVsComputerScore_PlayerShouldGetPoint_ReturnsPlayersScoreOne()
        {
            Player player = new Player();
            player.Value = "ROCK";
            Player computer = new Player();
            computer.Value = "SCISSORS";

            _game.YouVsComputerScore(player, computer);

            player.Score.Should().Be(1);
        }

        [Test]
        public void YouVsComputerScore_ComputerShouldGetPoint_ReturnsComputerScoreOne()
        {
            Player player = new Player();
            player.Value = "ROCK";
            Player computer = new Player();
            computer.Value = "PAPER";

            _game.YouVsComputerScore(player, computer);

            computer.Score.Should().Be(1);
        }

        [Test]
        public void ScoreCount_ShouldUpdateScore_ReturnsPlayersScoreUpdated()
        {
            var players = new List<Player>()
            {
                new Player { Name = "Player1", Score = 0 },
                new Player { Name = "Player2", Score = 0 }
            };

            var result = _game.ScoreCount(2, players);

            result.Should().Contain(player => player.Score > 0);
        }

        [Test]
        public void ScoreCount_RoundsAreZero_ThrowsZeroRoundsException()
        {
            Action act = () =>
            {
                var players = new List<Player>()
                {
                    new Player { Name = "Player1", Score = 0 },
                    new Player { Name = "Player2", Score = 0 }
                };

                _game.ScoreCount(0, players);
            };
            
            act.Should().Throw<ZeroRoundsException>();
        }

        [Test]
        public void GameResult_ShouldPrintGameResult_PrintsGameResult()
        {
            var players = new List<Player>()
            {
                new Player { Name = "Player1", Score = 3 },
                new Player { Name = "Player2", Score = 1 }
            };

            var consoleOutput = new StringWriter();
            
            Console.SetOut(consoleOutput);
            _game.GameResult(players);

            var expectedOutput = "Game results: \r\nPlayer1 - 3\r\nPlayer2 - 1\r\n";
            consoleOutput.ToString().Should().Be(expectedOutput);
            
        }
    }
}
