using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(80)")]//(up to 80 characters, unicode)
        public string? Description { get; set; }
        [Column(TypeName = "varchar(max)")]//(unicode, not required)
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public List<Student>? StudentId { get; set; } 
        public List<Resource>? ResourceId { get; set; } 
        public List<Homework>? HomeworkId { get; set; } 
        public List<StudentsEnrolled>? StudentsEnrolled { get; set; } 
    }
}
