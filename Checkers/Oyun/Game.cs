using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public class Game
    {
        public Game()
        {

        }
        public Game(string gamer1,string gamer2)
        {
            Gamer1 = gamer1; Gamer2 = gamer2;
        }
        public List<Coordinate> WhiteCoordinate { get; set; }
        public List<Coordinate> BlackCoordinate { get; set; }


        public string Gamer1 { get; set; }
        public string Gamer2 { get; set; }

        public string Queue { get; set; }

        public Move Move { get; set; }
    }
}
