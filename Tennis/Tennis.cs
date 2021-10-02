using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class Tennis
    {
        private int FirstPlayerScoreTimes { get; set; }

        public Tennis()
        {
            FirstPlayerScoreTimes = 0;
        }

        public string GetScore()
        {
            if (FirstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }

            return "Love all";
        }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }
    }
}
