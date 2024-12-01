using SkillPracticeBackendDev.DI;

namespace SkillPracticeBackendDev.UnitTests
{
    public class GameTest
    {
        [Fact]
        public void RockBeatScissors()
        {
            GameManager gameManager = new GameManager(new ForedPlayer(Choice.Rock), new ForedPlayer(Choice.Scissors));
            Assert.Equal(RoundResult.Player1Win, gameManager.PlayRound());
        }
    }
}