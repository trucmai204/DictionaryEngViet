using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database_Connector
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vocabulary> Vocabulary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Trusted_Connection=true;TrustServerCertificate=True;Server=TRUCMAI\\SQLEXPRESS;Database=Dictionary");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vocabulary>()
                .HasKey(v => v.Id); // Định nghĩa Id là khóa chính
        }
    }
}
