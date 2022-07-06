using ForOleksiyAspNet5.Models;
using Microsoft.EntityFrameworkCore;

namespace ForOleksiyAspNet5.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Moves> Moveses { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
