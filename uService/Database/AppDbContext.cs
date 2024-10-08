﻿using Microsoft.EntityFrameworkCore;
using uService.Models;

namespace uService.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Objednavka>()
                .HasMany(p => p.PolozkyObjednavky)
                .WithOne(p => p.Objednavka)
                .HasForeignKey(p => p.ObjednavkaId);


            modelBuilder.Entity<PolozkaObjednavky>()
                .HasKey(p => new { p.NazevZbozi, p.ObjednavkaId });

            modelBuilder.Entity<PolozkaObjednavky>()
                .HasOne(p => p.Objednavka)
                .WithMany(o => o.PolozkyObjednavky)
                .HasForeignKey(p => p.ObjednavkaId);
        }
                  

        public DbSet<Objednavka> Objednavky { get; set; }

        public DbSet<PolozkaObjednavky> PolozkyObjednavky { get; set; }

    }
}
