using FirstLevelGame.CustomExceptions;
using FluentAssertions;
using System.Text.RegularExpressions;
using Moq;
using Moq.AutoMock;
using System.Net.Sockets;

namespace FirstLevelGame.Tests
{
    public class GameTests
    {
        private Game? _game;
        private AutoMocker? _mocker;


        [SetUp]
        public void SetUp()
        {
            _game = new Game();
            _mocker = new AutoMocker();
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
        public void ScoreCount_ShouldCountComputerScore_ReturnComputerScoreCounted()
        {
            Player player = new Player { Value = "ROCK" };
            Player computer = new Player { Value = "PAPER" };
            var mockedGameSettings = _mocker.GetMock<GameSettings>();

            var game = new Game(mockedGameSettings.Object);

            game.ScoreCount(player, computer);

            computer.Score.Should().Be(1);
        }

        [Test]
        public void ScoreCount_ShouldCountPlayerScore_ReturnPlayerScoreCounted()
        {
            Player player = new Player { Value = "SCISSORS" };
            Player computer = new Player { Value = "PAPER" };
            var mockedGameSettings = _mocker.GetMock<GameSettings>();

            var game = new Game(mockedGameSettings.Object);

            game.ScoreCount(player, computer);

            player.Score.Should().Be(1);
        }


        [Test]
        public void ScoreCount_EmptyPlayerValueProvided_ThrowsEmptyPlayerValueException()
        {
            Action act = () =>
            {
                Player player = new Player();
                player.Value = "";
                Player computer = new Player();
                computer.Value = "PAPER";

                _game.ScoreCount(player, computer);
            };

            act.Should().Throw<EmptyPlayerValueException>();
        }

        [Test]
        public void ScoreCount_EmptyComputerValueProvided_ThrowsEmptyComputerValueException()
        {
            Action act = () =>
            {
                Player player = new Player();
                player.Value = "PAPER";
                Player computer = new Player();
                computer.Value = "";

                _game.ScoreCount(player, computer);
            };

            act.Should().Throw<EmptyComputerValueException>();
        }

        [Test]
        public void GameResult_WhenPlayerWins_ReturnsCongratulations()
        {
            Player player = new Player { Score = 2 };
            Player computer = new Player { Score = 1 };
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            _game.GameResult(player, computer);

            consoleOutput.ToString().Should().Contain("Congratulations! You won this game!");
        }

        [Test]
        public void GameResult_WhenGameIsATie_ReturnsGameIsATie()
        {
            Player player = new Player { Score = 1 };
            Player computer = new Player { Score = 1 };
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            _game.GameResult(player, computer);

            consoleOutput.ToString().Should().Contain("Appears to be a tie =)");
        }

        [Test]
        public void GameResult_WhenComputerWins_ReturnsYouLost()
        {
            Player player = new Player { Score = 1 };
            Player computer = new Player { Score = 2 };
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            _game.GameResult(player, computer);

            consoleOutput.ToString().Should().Contain("Unfortunately, you have lost this game...");
        }

        /* ToDo */

        [Test]
        public void RunGame_TimesShouldRunInputCheck_RunsThreeTimes()
        {
            var game = _mocker.CreateInstance<Game>();

            var stringWriter = new StringWriter();
            var input = new StringReader("ROCK\nPAPER\nSCISSORS\n");

            Console.SetIn(input);
            Console.SetOut(stringWriter);
 
            game.RunGame();

            _mocker.Verify<Game>(x => x.InputCheck(It.IsAny<Player>()), Times.Exactly(3));
            
        }
    }
}
