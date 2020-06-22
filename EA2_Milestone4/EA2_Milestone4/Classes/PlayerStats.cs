using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EA2_Milestone4.Classes
{
    class PlayerStats : IComparable
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeFinish { get; set; }
        public string Difficulty { get; set; }

        public int GameSize { get; set; }

        public PlayerStats(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public PlayerStats()
        {
            Name = "";
            Score = -1;
            TimeFinish = new TimeSpan();
        }

        public int CompareTo(object obj)
        {
            var other = (PlayerStats)obj;
            if (this.Score == other.Score)
            {
                return this.Name.CompareTo(other.Name);
            }
            return other.Score.CompareTo(this.Score);
        }
    }
}
