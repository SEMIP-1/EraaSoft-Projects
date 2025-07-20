using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]//(up to 100 characters, unicode)
        public string? PhoneNumber { get; set; }
        [Column(TypeName = "varchar(10)")]//(exactly 10 characters, not unicode, not required)
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }
        public List<Course>? CourseId { get; set; } 
        public List<Homework>? HomeworkId { get; set; } 
        public List<StudentsEnrolled>? StudentsEnrolled { get; set; } 
    }
}
