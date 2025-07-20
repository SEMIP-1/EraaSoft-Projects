using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    public class Homework 
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; } = string.Empty;
        [Column(TypeName = "varchar(max)")]// (linking to a file, not unicode)
        public ContentType ContentType { get; set; } //ContentType(enum – can be Application, Pdf or Zip)
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; } 
    }
}