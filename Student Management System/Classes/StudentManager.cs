using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class StudentManager
    {
        #region Properties:
        public List<Student> Students;
        public List<Course> Courses;
        public List<Instructor> Instructors;
        #endregion

        

        #region Methods
        public void AddStudent(Student student) 
        {
            Students.Add(student);
        }
        public void AddCourse(Course course) 
        { 
            Courses.Add(course);
        }
        public void AddInstructor(Instructor instructor) 
        { 
            Instructors.Add(instructor);
        }
        public void FindStudent(int studentId) 
        { 
            foreach (var student in Students)
            {
                if (student.StudentId == studentId)
                {
                    student.PrintDetails();
                    return;
                }
            }
        }
        public void FindCourse(int courseId) 
        { 
            foreach (var course in Courses)
            {
                if (course.CourseId == courseId)
                {
                    course.PrintDetails();
                    return;
                }
            }
        }
        public Instructor FindInstructor(int instructorId) { }
        public void EnrollStudentInCourse(int studentId, int courseId) { }
        #endregion
    }
}
