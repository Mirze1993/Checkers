using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public class Move
    {
        public Move()
        {

        }        
        
        public byte OldX { get; set; }
        public byte OldY { get; set; }        
        public byte NewX { get; set; }        
        public byte NewY { get; set; }        
    }
}
