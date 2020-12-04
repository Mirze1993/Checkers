using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.DB
{
    public interface IRepostory
    {
        void createUser(User u);
        User GetUser(int id);
        User GetUser(string name);
        IList<User> AllUser();
        void CreateGame(Game g);
        void UpdateGame(Game g);
        GelenVEGedenIstekler getGames(User u);
        Game GetGame(User gonderen, User qebuleden);
    }
}
