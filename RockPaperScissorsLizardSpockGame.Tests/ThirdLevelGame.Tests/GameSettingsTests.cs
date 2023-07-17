using FluentAssertions;
using ThirdLevelGame.CustomExceptions;

namespace ThirdLevelGame.Tests
{
    public class GameSettingsTests
    {
        private GameSettings _gameSettings;

        [SetUp]
        public void Setup()
        {
            _gameSettings = new GameSettings();
        }

        [Test]
        public void RandomMove_SetValidRandomMove_ReturnRandomMove()
        {
            Player player = new Player();

            var move = _gameSettings.RandomMove(player);

            player.Value.Should().Be(move);
        }

        [Test]
        public void CreatePlayers_ShouldReturnPlayersList_ReturnsPlayersList()
        {
            int number = 3;

            var result = _gameSettings.CreatePlayers(number);

            result.Should().HaveCount(number);
        }

        [Test]
        public void CreatePlayers_NumberIsZero_ThrowsEmptyListException()
        {
            Action act = () =>
            {
                _gameSettings.CreatePlayers(0);
            };
            
            act.Should().Throw<EmptyListException>();
        }

        [Test]
        public void CreatePlayers_ShouldSetPlayersCorrectNames_ReturnsPlayersListWithCorrectNames()
        {
            var result = _gameSettings.CreatePlayers(2);

            result.Should().OnlyContain(player => player.Name.StartsWith("Player"));
        }

        [Test]
        public void CreatePlayers_ShouldSetPlayersWithEmptyStringValueAndZeroScore_ReturnsValidPlayers()
        {
            var result = _gameSettings.CreatePlayers(2);

            result.Should().OnlyContain(player => player.Value == "" && player.Score == 0);
        }
    }
}