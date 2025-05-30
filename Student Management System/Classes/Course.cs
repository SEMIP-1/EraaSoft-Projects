using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Course
    {
        #region Properties
        public int CourseId {get; set;}
        public string Title { get; set; }
        public Instructor Instructor { get; set; }
        #endregion

        #region Methods
        public void PrintDetails() 
        {
            Console.WriteLine($"Course ID: {CourseId}");
            Console.WriteLine($"Title: {Title}");
            if (Instructor != null)
            {
                Console.WriteLine($"Instructor: {Instructor.Name} (ID: {Instructor.InstructorId})");
            }
            else
            {
                Console.WriteLine("No instructor assigned.");
            }
        }
        #endregion
    }
}
