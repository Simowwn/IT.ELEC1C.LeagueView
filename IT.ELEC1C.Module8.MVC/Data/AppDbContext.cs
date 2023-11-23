using IT.ELEC1C.LeagueView.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IT.ELEC1C.LeagueView.MVC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Users> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
    }
}
