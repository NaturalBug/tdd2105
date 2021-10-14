using Xunit;

namespace Tennis.Tests
{
    public class TennisTests
    {
        private readonly Tennis _tennis = new Tennis();

        [Fact]
        public void GetScore_NoOneScore_ReturnsLoveAll()
        {
            var score = _tennis.GetScore();

            Assert.Equal("Love all", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreOnce_ReturnsFifteenLove()
        {
            _tennis.FirstPlayerScore();

            var score = _tennis.GetScore();

            Assert.Equal("Fifteen Love", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreTwice_ReturnsThirtyLove()
        {
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();

            var score = _tennis.GetScore();

            Assert.Equal("Thirty Love", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreThrice_ReturnsFortyLove()
        {
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();

            var score = _tennis.GetScore();

            Assert.Equal("Forty Love", score);
        }
    }
}
