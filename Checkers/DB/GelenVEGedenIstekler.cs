using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.DB
{
    public class GelenVEGedenIstekler
    {
        public GelenVEGedenIstekler()
        {
            Gedenler = new List<Game>();
            Gelenler = new List<Game>();
        }
        public List<Game> Gedenler { get; set; }
        public List<Game> Gelenler { get; set; }
    }
}
