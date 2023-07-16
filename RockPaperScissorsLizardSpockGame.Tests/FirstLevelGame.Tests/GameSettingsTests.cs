using FluentAssertions;

namespace FirstLevelGame.Tests
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
    }
}