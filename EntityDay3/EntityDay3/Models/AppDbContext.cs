using Microsoft.EntityFrameworkCore;

namespace EntityDay3.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-C3O452Q;Database=EntityDb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
