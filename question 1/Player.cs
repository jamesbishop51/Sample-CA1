using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    public class Player
    {

        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public Player(int id, string playername, int score)
        {
            ID = id;
            PlayerName = playername;
            Score = score;
        }

        public void ScoreIncrease(int ValueToadd)
        {
            Score += ValueToadd;
        }
    }
}
