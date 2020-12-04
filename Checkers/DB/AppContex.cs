using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.DB
{
    public class AppContex:DbContext
    {
        public AppContex(DbContextOptions<AppContex> options):base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Game> games { get; set; }
         
    }
}
