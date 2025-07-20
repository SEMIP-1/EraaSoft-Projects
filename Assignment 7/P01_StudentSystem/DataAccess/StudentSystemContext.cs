using Microsoft.EntityFrameworkCore;
using System;
namespace P01_StudentSystem
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentsEnrolled> StudentsEnrolleds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            
        }
    }
}


