using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {

            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=rensourcedb;Username=postgres;Password=root");
        }

        public DbSet<FaireDataModel> faires { get; set; }

        }

}