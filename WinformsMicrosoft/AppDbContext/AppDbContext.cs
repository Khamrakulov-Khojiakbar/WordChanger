using Microsoft.EntityFrameworkCore;
using WinformsMicrosoft.Domain;

namespace WinformsMicrosoft
{
    public class AppDbContext : DbContext
    {

        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<IllnessCategory> illnessCategories { get; set; }

        public DbSet<Pains> Pains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Port=5432;Database=AvangardTest;Username=postgres;Password=1221;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
