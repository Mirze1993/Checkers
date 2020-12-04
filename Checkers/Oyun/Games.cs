using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public static class Games
    {
        private static IList<Game> game;

        public static IList<Game> AllGame
        {
            get
            {
                if (game == null) game = new List<Game>();
                return game;
            }
            set
            {
                if (game == null) game = new List<Game>();
                game = value;
            }
        }
 
        public static Game GetGame(string gamer1, string gamer2)
        {
            var game = AllGame.Where(x => x.Gamer1 == gamer1 && x.Gamer2 == gamer2).FirstOrDefault();  
            if(game==null) game= AllGame.Where(x => x.Gamer1 == gamer2 && x.Gamer2 == gamer1).FirstOrDefault();
            if (game == null)
            {
                game = new Game(gamer1, gamer2)
                {
                    WhiteCoordinate = new List<Coordinate>(){
                    new Coordinate(){X=0,Y=0},
                    new Coordinate(){X=2,Y=0},
                    new Coordinate(){X=4,Y=0},
                    new Coordinate(){X=6,Y=0},

                    new Coordinate(){X=1,Y=1},
                    new Coordinate(){X=3,Y=1},
                    new Coordinate(){X=5,Y=1},
                    new Coordinate(){X=7,Y=1},

                    new Coordinate(){X=0,Y=2},
                    new Coordinate(){X=2,Y=2},
                    new Coordinate(){X=4,Y=2},
                    new Coordinate(){X=6,Y=2},
                    },

                    BlackCoordinate = new List<Coordinate>(){
                    new Coordinate(){X=1,Y=5},
                    new Coordinate(){X=3,Y=5},
                    new Coordinate(){X=5,Y=5},
                    new Coordinate(){X=7,Y=5},

                    new Coordinate(){X=0,Y=6},
                    new Coordinate(){X=2,Y=6},
                    new Coordinate(){X=4,Y=6},
                    new Coordinate(){X=6,Y=6},

                    new Coordinate(){X=1,Y=7},
                    new Coordinate(){X=3,Y=7},
                    new Coordinate(){X=5,Y=7},
                    new Coordinate(){X=7,Y=7},
                    },
                    Queue = gamer1,
                    Move = new Move()
                };
                 AllGame.Add(game);
            }
            return game;
        }

        public static Game SetGame(Game g)
        {
            for (int i = 0; i < AllGame.Count; i++)
            {
                if ((AllGame[i].Gamer1 == g.Gamer1 && AllGame[i].Gamer2 == g.Gamer2)
                    || (AllGame[i].Gamer2 == g.Gamer1 && AllGame[i].Gamer1 == g.Gamer2))
                    AllGame[i] = g;
            }            
            return g;
        }
    }
}
