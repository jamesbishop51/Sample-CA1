﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            List<Player> Allplayers = new List<Player>();
            Allplayers.Add(player1);
            Allplayers.Add(player2);
            Allplayers.Add(player3);
            Allplayers.Add(player4);
            Allplayers.Add(player5);

            player1.ScoreIncrease(20);
            player4.ScoreIncrease(99);

        }
    }
}
