using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace Challenge_9._1
{
    public class ApplicationDBContexts : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;;Initial Catalog=EFProject516;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

    }
}
