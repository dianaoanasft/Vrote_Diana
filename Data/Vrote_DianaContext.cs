using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vrote_Diana.Models;

namespace Vrote_Diana.Data
{
    public class Vrote_DianaContext : DbContext
    {
        public Vrote_DianaContext (DbContextOptions<Vrote_DianaContext> options)
            : base(options)
        {
        }

        public DbSet<Vrote_Diana.Models.Home> Home { get; set; } = default!;

        public DbSet<Vrote_Diana.Models.PossibleBuyer>? PossibleBuyer { get; set; }

        public DbSet<Vrote_Diana.Models.HomeType>? HomeType { get; set; }

        public DbSet<Vrote_Diana.Models.Location>? Location { get; set; }

        public DbSet<Vrote_Diana.Models.Rent>? Rent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Home>()
                .HasOne(b => b.Rent)
                .WithOne(b => b.Home)
                .HasForeignKey<Rent>(b => b.HomeID);




        }

    }

}
