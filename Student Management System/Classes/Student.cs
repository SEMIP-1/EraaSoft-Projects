using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        #region Properties
        public int StudentId;
        public string Name;
        public int Age;
        public List<Course> Courses;
        #endregion

        #region Constructors
        public Student() { }
        #endregion

        #region Methods
        public bool Enroll(Course course) { }
        public string PrintDetails() { }
        #endregion
    }
}
