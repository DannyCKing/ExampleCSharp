using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Models
{
    public class Student : IPerson
    {
        public Guid Id
        {
            get;
            private set;
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public string SSN
        {
            get;
            private set;
        }

        private List<Course> _Courses;

        public List<Course> Courses
        {
            get
            {
                return _Courses;
            }
            private set
            {
                _Courses = value;
            }

        }

        /// <summary>
        /// Construtor for the student object
        /// </summary>
        /// <param name="firstName">The first name or given name of the student</param>
        /// <param name="lastName">The last name of the student</param>
        /// <param name="SSN">The SSN of the student</param>
        public Student(string firstName, string lastName, string ssn)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            _Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            _Courses.Add(course);
        }

        internal string GetStudentOutput()
        {
            string result = "";
            result += "Name: " + FirstName + " " + LastName + Environment.NewLine;
            result += "Course(s): " + Courses.Count + Environment.NewLine;
            foreach (var course in Courses)
            {
                result += course.CourseName + Environment.NewLine;
            }
            return result;
        }
    }
}
