using System;
using System.Collections.Generic;
using System.Text;
using CodeFirst.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(SampleData.GetTeams());
            modelBuilder.Entity<Player>().HasData(SampleData.GetPlayers());
        }
    }
}
