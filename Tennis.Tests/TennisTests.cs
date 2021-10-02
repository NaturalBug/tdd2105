using System;
using Xunit;

namespace Tennis.Tests
{
    public class TennisTests
    {
        Tennis tennis = new Tennis();

        [Fact]
        public void GetScore_NoOneScore_ReturnLoveAll()
        {
            string score = tennis.GetScore();

            Assert.Equal("Love all", score);
        }

        [Fact]
        public void GetScore_FirstPlayerScoreOnce_ReturnFifteenLove()
        {
            tennis.FirstPlayerScore();

            string score = tennis.GetScore();

            Assert.Equal("Fifteen Love", score);
        }

        [Fact]
        public void GetScroe_FisrtPlayerScoreTwice_ReturnThirtyLove()
        {
            tennis.FirstPlayerScore();
            tennis.FirstPlayerScore();

        }
    }
}
