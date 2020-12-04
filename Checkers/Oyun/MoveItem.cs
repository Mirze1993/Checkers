using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Oyun
{
    public class MoveItem
    {
        public MoveItem(Game g,byte oldX,byte oldY,byte newX,byte newY)
        {
            G = g;
            OldX = oldX;
            OldY = oldY;
            NewX = newX;
            NewY = newY;
            G.Move = new Move()
            {                
                NewX = newX,
                NewY = newY,
                OldX = oldX,
                OldY = oldY
            };
        }

        public Game G { get; }
        public byte OldX { get; }
        public byte OldY { get; }
        public byte NewX { get; }
        public byte NewY { get; }       

        public Game MoveBlack()
        {
            for (int i = 0; i < G.BlackCoordinate.Count; i++)
            {
                if (G.BlackCoordinate[i].X == OldX && G.BlackCoordinate[i].Y == OldY)
                { G.BlackCoordinate[i].X = NewX; G.BlackCoordinate[i].Y = NewY; }
            }            
            return G;
        }

        public Game MoveWhite()
        {
            for (int i = 0; i < G.WhiteCoordinate.Count; i++)
            {
                if (G.WhiteCoordinate[i].X == OldX && G.WhiteCoordinate[i].Y == OldY)
                { G.WhiteCoordinate[i].X = NewX; G.WhiteCoordinate[i].Y = NewY; }
            }
            return G;
        }

        internal Game DumWhite()
        {
            byte x1 = (byte)((OldX + NewX) / 2);
            byte y1 = (byte)((OldY + NewY) / 2);            
            G.BlackCoordinate.RemoveAt(G.BlackCoordinate.FindIndex(c =>  c.X == x1 && c.Y == y1));
            
            return MoveWhite();
        }

        internal Game DumBlack()
        {
            byte x1 = (byte)((OldX + NewX) / 2);
            byte y1 = (byte)((OldY + NewY) / 2);           
            G.WhiteCoordinate.RemoveAt(G.WhiteCoordinate.FindIndex(c => c.X == x1 && c.Y == y1));
            return MoveBlack();
        }
    }
}
