using Anime.Models;
using Microsoft.EntityFrameworkCore;

namespace Anime.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Animes> Animes { get; set; }
    }
}
