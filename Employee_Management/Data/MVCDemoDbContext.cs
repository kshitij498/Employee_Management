using Employee_Management.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
