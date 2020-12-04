using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.DB
{
    public class Repostory : IRepostory
    {
        public Repostory(AppContex contex)
        {
            Con = contex;
        }

        public AppContex Con { get; }

        public IList<User> AllUser()
        {
          return  Con.users.ToList();
        }

        public void CreateGame(Game g)
        {
            Con.games.Add(g);
            Con.SaveChanges();
        }

        public void createUser(User u)
        {
            Con.users.Add(u);
            Con.SaveChanges();

        }

        public Game GetGame(User gonderen, User qebuleden)
        {
            return Con.games.Include(x => x.User1).Include(x => x.User2).Where(x => x.User1 == gonderen && x.User2 == qebuleden).FirstOrDefault();
        }

        public GelenVEGedenIstekler getGames(User u)
        {
            var gelen =Con.games.Include(x=>x.User1).Include(x=>x.User2).Where(x => x.User2 == u).ToList();
            var geden =Con.games.Include(x => x.User1).Include(x => x.User2).Where(x => x.User1 == u).ToList(); 
            return new GelenVEGedenIstekler() {Gedenler=geden ,Gelenler=gelen};
        }

        public User GetUser(int id)
        {
            return Con.users.FirstOrDefault(x => x.Id == id);
        }

        public User GetUser(string name)
        {
            return Con.users.FirstOrDefault(x => x.Name == name);
        }

        public void UpdateGame(Game g)
        {
            Con.Entry(g).State = EntityState.Modified;
            Con.SaveChanges();
        }
    }
}
