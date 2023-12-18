using Microsoft.EntityFrameworkCore;
using System;
using System.IO; // Add this line

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             var dbPath = Path.Combine(Environment.CurrentDirectory, "Data", "datingapp.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            // Call the base class implementation for additional configuration
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<AppUser> Users { get; set; }
        
        
    }
}
