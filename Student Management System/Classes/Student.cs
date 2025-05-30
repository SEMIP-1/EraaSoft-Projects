using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Student
    {
        #region Properties
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
        #endregion
        
        #region Constructors
        public Student() 
        {
            Courses = new List<Course>();
        }
        #endregion

        #region Methods
        public void Enroll(Course course) 
        {
            this.Courses.Add(course);
        }
        public void PrintDetails() 
        {  
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine($"- {course.Title} (ID: {course.CourseId})");
            }
        }
        #endregion
    }
}
