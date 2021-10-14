using Xunit;

namespace Tennis.Tests
{
    public class TennisTests
    {
        private readonly Tennis tennis = new Tennis();

        [Fact]
        public void GetScore_NoOneScore_ReturnLoveAll()
        {
            var score = tennis.GetScore();

            Assert.Equal("Love all", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreOnce_ReturnFifteenLove()
        {
            tennis.FirstPlayerScore();

            var score = tennis.GetScore();

            Assert.Equal("Fifteen Love", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreTwice_ReturnThirtyLove()
        {
            tennis.FirstPlayerScore();
            tennis.FirstPlayerScore();

            var score = tennis.GetScore();

            Assert.Equal("Thirty Love", score);
        }
    }
}
