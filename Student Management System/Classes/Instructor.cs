using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Instructor
    {
        #region Properties
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        #endregion



        #region Methods
        public void PrintDetails() 
        {
            Console.WriteLine($"Instructor ID: {InstructorId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Specialization: {Specialization}");
        }
        #endregion  
    }
}
