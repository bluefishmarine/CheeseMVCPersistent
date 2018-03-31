using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public DbSet<Cheese> Cheeses { get; set; }

        public DbSet<CheeseCategory> Categories { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<CheeseMenu> CheeseMenu { get; set; }

        public List<Cheese> Include { get; internal set; }

        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheeseMenu>()
                .HasKey(c => new { c.CheeseID, c.MenuID });
        }

    }
}
