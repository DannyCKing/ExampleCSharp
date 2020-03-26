using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Models
{
    /// <summary>
    /// Object to represent an instance of a course being taught. Ex: Math 1010 Fall 2020
    /// </summary>
    public class Course
    {
        /// <summary>
        /// A id to ensure uniqueness between courses.  Could be used as a PK
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { get; private set; }

        /// <summary>
        /// The instructor of the class
        /// </summary>
        public Instructor Instructor { get; private set; }

        /// <summary>
        /// The list of students current in the class
        /// </summary>
        public List<Student> CourseStudents { get; private set; }

        /// <summary>
        /// The year the course was taught
        /// </summary>
        public int YearTaught { get; private set; }

        /// <summary>
        /// The semster the course was taught
        /// </summary>
        public Semester SemesterTaught { get; private set; }

        /// <summary>
        /// Constructor for the course object
        /// </summary>
        /// <param name="courseName">The name of the course</param>
        /// <param name="year">The year of the class being taught</param>
        /// <param name="semester">The semester the class is being taught(spring fall, summer)</param>
        public Course(string courseName, int year, Semester semester)
        {
            CourseName = courseName;

            CourseStudents = new List<Student>();

            YearTaught = year;
            SemesterTaught = semester;
        }

        public void SetInstructor(Instructor instructor)
        {
            Instructor = instructor;
        }

        /// <summary>
        /// Add a student to a couse
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            CourseStudents.Add(student);
        }
    }
}
