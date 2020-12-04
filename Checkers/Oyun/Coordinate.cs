using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public class Coordinate
    {
        public byte X { get; set; }
        public byte Y { get; set; }

        public Coordinate()
        {

        }

        public Coordinate(byte x,byte y)
        {
            X = x;Y = y;
        }
    }

}
