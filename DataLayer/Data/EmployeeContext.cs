using DataLayer.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=Desktop-3k1fu5f; initial catalog=Employee;persist security info=True;user id=Mekala;password=Ramesh@007");
        }
    }
}
