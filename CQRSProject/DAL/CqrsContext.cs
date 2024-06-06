using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL
{
    public class CqrsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-P40Q2KE\\SQLEXPRESS; Initial Catalog = CqrsDB; Integrated Security = true ");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
