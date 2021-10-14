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
            FirstPlayerScoreTimes(1);

            var score = _tennis.GetScore();

            Assert.Equal("Fifteen Love", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreTwice_ReturnsThirtyLove()
        {
            FirstPlayerScoreTimes(2);

            var score = _tennis.GetScore();

            Assert.Equal("Thirty Love", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreThrice_ReturnsFortyLove()
        {
            FirstPlayerScoreTimes(3);

            var score = _tennis.GetScore();

            Assert.Equal("Forty Love", score);
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }
    }
}
