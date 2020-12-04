using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public class MainControl
    {
        public MainControl(string gamer1, string gamer2)
        {
            Gamer1 = gamer1;
            Gamer2 = gamer2;
        }

        public string Gamer1 { get; }
        public string Gamer2 { get; }

        public Game GetGame()
        {
            return Games.GetGame(Gamer1, Gamer2);
        }

        public List<Coordinate> MoveAbleTo(string x,string y)
        {
            var game = Games.GetGame(Gamer1, Gamer2);
            if (game.Gamer1 == game.Queue) return new WhiteAbleToGo(game).getSimple(Convert.ToByte(x), Convert.ToByte(y));
            else if (game.Gamer2 == game.Queue) return new BlackAbleToGo(game).getSimple(Convert.ToByte(x), Convert.ToByte(y));               
            return null;
        }

        public Move Move(string OldX, string OldY, string NewX, string NewY)
        {
            var game = Games.GetGame(Gamer1, Gamer2);
            var moveItem = new MoveItem(game, Convert.ToByte(OldX), Convert.ToByte(OldY)
                , Convert.ToByte(NewX), Convert.ToByte(NewY));            

            if (game.Gamer1 == game.Queue)
            {
                game = moveItem.MoveWhite();
                game.Queue = game.Gamer2;
                Games.SetGame(game);
            }
            else if (game.Gamer2 == game.Queue)
            {
                game = moveItem.MoveBlack();
                game.Queue = game.Gamer1;
                Games.SetGame(game);
            }
            return game.Move;
        }

        public Move Dum(string OldX, string OldY, string NewX, string NewY)
        {
            var game = Games.GetGame(Gamer1, Gamer2);
            var moveItem = new MoveItem(game, Convert.ToByte(OldX), Convert.ToByte(OldY)
                , Convert.ToByte(NewX), Convert.ToByte(NewY));

            if (game.Gamer1 == game.Queue)
            {
                game = moveItem.DumWhite();
                game.Queue = game.Gamer2;
                Games.SetGame(game);
            }
            else if (game.Gamer2 == game.Queue)
            {
                game = moveItem.DumBlack();
                game.Queue = game.Gamer1;
                Games.SetGame(game);
            }
            return game.Move;
        }
    }
}
