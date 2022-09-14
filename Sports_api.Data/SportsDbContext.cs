using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sports_api.Domain;

namespace Sports_api.Data
{
    public class SportsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1401; Database=SportsDb; User Id=SA; Password=1StrongPassword")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information )
                .EnableSensitiveDataLogging();
        }

        public DbSet<Team>? Teams { get; set; }
        public DbSet<League>? Leagues { get; set; }
    }
}

