using ManageEmployee3.Domain.Entities;
using System.Data.Entity;

namespace ManageEmployee3.Domain
{
    public class ManageEmployeeDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Department> Departments { get; set; }
    }
}
