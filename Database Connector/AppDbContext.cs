using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database_Connector
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vocabulary> Vocabulary { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vocabulary>()
                .HasKey(v => v.Id); // Định nghĩa Id là khóa chính
        }
    }
}
