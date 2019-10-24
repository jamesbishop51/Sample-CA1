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
        public int Score { get; set; }

        public Player(int id, string playername, int score)
        {
            ID = id;
            PlayerName = playername;
            Score = score;
        }
    }
}
