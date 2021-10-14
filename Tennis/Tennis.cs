using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class Tennis
    {
        private int FirstPlayerScoreTimes { get; set; }

        private readonly Dictionary<int, string> _scoreName = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        public Tennis()
        {
            FirstPlayerScoreTimes = 0;
        }

        public string GetScore()
        {
            if (FirstPlayerScoreTimes > 0)
            {
                return $"{_scoreName[FirstPlayerScoreTimes]} Love";
            }

            return "Love all";
        }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }
    }
}
