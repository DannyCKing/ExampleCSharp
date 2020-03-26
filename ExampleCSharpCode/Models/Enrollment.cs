using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Models
{
    /// <summary>
    /// Class meant to store data about the enrollment for a semester
    /// </summary>
    public class Enrollment
    {
        public List<Course> Courses { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Instructor> Instructors { get; private set; }

        public Enrollment(List<Course> courses, List<Student> students, List<Instructor> teachers)
        {
            Courses = courses;
            Students = students;
            Instructors = teachers;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Instructor teacher)
        {
            Instructors.Add(teacher);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        internal void SetInstructorForCourse(Course course, Instructor instructor)
        {
            instructor.AddCourse(course);
            course.SetInstructor(instructor);
        }

        internal void EnrollStudentInClass(Course course, Student student)
        {
            course.AddStudent(student);
            student.AddCourse(course);
        }
    }
}
