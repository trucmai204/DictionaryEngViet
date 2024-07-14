using Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Database_Connector
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vocabulary> Vocabulary {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Trusted_Connection=true;TrustServerCertificate=True;Server=SQLEXPRESS;Database=Dictionary");
        }
    }
}
