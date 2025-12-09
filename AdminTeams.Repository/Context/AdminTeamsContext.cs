using AdminTeams.Domain.Entities;
using AdminTeams.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace AdminTeams.Repository.Context
{
    public class AdminTeamsContext : DbContext
    {        public AdminTeamsContext(DbContextOptions<AdminTeamsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>(new TeamMap().Configure);
            modelBuilder.Entity<Position>(new PositionMap().Configure);
            modelBuilder.Entity<Player>(new PlayerMap().Configure);
        }
    }
}