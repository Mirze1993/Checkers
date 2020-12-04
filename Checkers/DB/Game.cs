using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.DB
{
    public class Game
    {
        public int Id { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
        public bool State { get; set; }
    }
}
