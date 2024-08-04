using Microsoft.EntityFrameworkCore;
using uService.Models;

namespace uService.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Objednavka> Objednavky { get; set; }

        public DbSet<PolozkaObjednavky> PolozkyObjednavky { get; set; }

    }
}
