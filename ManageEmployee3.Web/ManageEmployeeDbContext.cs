using ManageEmployee3.Web.Models;
using System.Data.Entity;

namespace ManageEmployee3.Web
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
