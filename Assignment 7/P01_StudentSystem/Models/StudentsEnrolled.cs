using Microsoft.EntityFrameworkCore;
using System;

namespace P01_StudentSystem
{
    [PrimaryKey("StudentId", "CourseId")]
    public class StudentsEnrolled
    {
        public int StudentsEnrolledId { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        
    }
}