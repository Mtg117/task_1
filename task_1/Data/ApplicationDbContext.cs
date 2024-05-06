using Microsoft.EntityFrameworkCore;
using task_1.Models;

namespace task_1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ASP81;trusted_connection=true;TrustServerCertificate=true;");
        }
    }
}
