using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Models
{
    /// <summary>
    /// The teacher class meant to represent the teacher individual
    /// </summary>
    public class Instructor : IPerson
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

        public List<Course> CoursesTaught
        {
            get; private set;
        }

        public Instructor(string firstName, string lastName, string SSN)
        {
            Id = Guid.NewGuid();
            CoursesTaught = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            CoursesTaught.Add(course);
        }
    }
}
