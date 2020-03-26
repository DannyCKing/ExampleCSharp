using ExampleCSharpCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode.Utilities
{
    public class TestEnrollmentData
    {
        Random Random = new Random(new Random().Next());

        public TestEnrollmentData()
        {
        }

        /// <summary>
        /// Function meant to create sample student data
        /// </summary>
        /// <returns></returns>
        public Enrollment GetSampleData()
        {
            List<Course> courses = GetSampleCourseList();
            List<Student> students = GetSampleStudentList(100);
            List<Instructor> teachers = GetSampleTeacherList(8);

            var result = new Enrollment(courses, students, teachers);

            // set instructor for each course
            foreach (var course in result.Courses)
            {
                var instructor = GetRandomInstructorFromList(result.Instructors);

                result.SetInstructorForCourse(course, instructor);
            }

            // set list of students for each course
            foreach (var student in result.Students)
            {
                foreach (var course in result.Courses)
                {
                    // randomly enroll students for test data
                    if (Random.NextDouble() < 0.05)
                    {
                        result.EnrollStudentInClass(course, student);
                    }
                }
            }

            return result;
        }

        private Instructor GetRandomInstructorFromList(List<Instructor> teachers)
        {
            var randomindex = Random.Next(teachers.Count);

            return teachers[randomindex];
        }

        private List<Course> GetSampleCourseList()
        {
            var result = new List<Course>();
            foreach (var subject in SampleCourseSubjects)
            {
                foreach (var courseNumber in SampleCourseNumber)
                {
                    result.Add(new Course(subject + " " + courseNumber, 2020, Semester.Summer));
                }
            }

            return result;
        }

        private List<Instructor> GetSampleTeacherList(int numberOfTeachers)
        {
            List<Instructor> result = new List<Instructor>();
            for (int x = 0; x < numberOfTeachers; x++)
            {
                Instructor instructor = new Instructor(GetFirstName(), GetRandomLastName(), GetRandomSSN());
                result.Add(instructor);
            }

            return result;
        }

        private List<Student> GetSampleStudentList(int numberOfStudents)
        {
            List<Student> result = new List<Student>();
            for (int x = 0; x < numberOfStudents; x++)
            {
                Student student = new Student(GetFirstName(), GetRandomLastName(), GetRandomSSN());
                result.Add(student);
            }

            return result;
        }

        private string GetRandomSSN()
        {
            string result = "";
            for(int i = 0; i < 9; i++)
            {
                // generate 0 - 9
                int x = Random.Next(10);
                result += x.ToString();
            }

            return result;
        }

        private string GetRandomLastName()
        {
            var randomindex = Random.Next(RandomListOfLastNames.Count);

            return RandomListOfLastNames[randomindex];
        }

        private string GetFirstName()
        {
            var randomindex = Random.Next(RandomFirstNameList.Count);

            return RandomFirstNameList[randomindex];
        }

        // SAMPLE DATE TO USE

        List<string> SampleCourseSubjects = new List<string> { "MATH", "PHYSICS", "ENGLISH", "BIOLOGY", "CHEMISTRY", "COMPUTER SCIENCE", "MECHANICAL ENGINEERING", "MUSIC" };
        List<int> SampleCourseNumber = new List<int> { 900, 1000, 1010, 1050, 1060, 1080, 2000, 2050, 2100, 2400, 2800, 3100, 3500, 4100, 4500, 4800 };

        List<string> RandomFirstNameList = new List<string> { "Ayako", "Tiera", "Maryam", "Maryalice", "Jina", "Doug", "Hiroko", "Heidi", "Kathleen", "Tonda", "Holly", "Annabelle", "Freddy", "Deadra", "Jonelle", "Wilbur", "Goldie", "Dennis", "Lyman", "Shaunta", "Sung", "Alice", "Milford", "Mina", "Waltraud", "Venice", "Amanda", "Cheryll", "Tamisha", "Demetrius", "Enoch", "Regan", "Tony", "Fabiola", "Saran", "Laure", "Miyoko", "Owen", "Lynell", "Bella", "Mikel", "Kit", "Jenelle", "Elida", "Wilmer", "Mauricio", "Jacquelyne", "Ellamae", "Willian", "Lashay", "Kimberli", "Shin", "Deloise", "Laurinda", "Collen", "Danille", "Susannah", "Erline", "Trevor", "Marx", "Cherise", "Mammie", "Audrie", "Tabitha", "Cruz", "Reginia", "Ronald", "Norine", "Tiffaney", "Cordie", "Kenna", "Nakia", "Lessie", "Morgan", "Chad", "Debi", "Moses", "Lakiesha", "Janeen", "Cory", "Candi", "Bob", "Tawanda", "Mauricio", "Tomika", "Nikki", "Calandra", "Ivy", "Glenda", "Lezlie", "Clare", "Kecia", "Lien", "Tanner", "Jana", "Carmen", "Sherlyn", "Blaine", "Leesa", "Raye" };
        private List<String> RandomListOfLastNames = new List<string>() { "Riddle", "Zhang", "Barry", "Burch", "Mckinney", "Vargas", "Best", "Gardner", "Mclean", "Livingston", "Mccormick", "Mendez", "Boyle", "West", "May", "Atkins", "Blackburn", "Ferrell", "Barnett", "Robbins", "Mayer", "Avery", "Simon", "Watts", "Mathews", "Trevino", "Mcgee", "Weiss", "Everett", "Koch", "Cannon", "Bray", "Vazquez", "Molina", "Summers", "Owen", "Huynh", "Arias", "Lloyd", "Luna", "Obrien", "Lyons", "Kerr", "Shields", "Sims", "Phelps", "Morris", "Sweeney", "French", "Swanson", "Andrade", "Ruiz", "Hahn", "Ho", "Flynn", "Archer", "Acosta", "Ellison", "Clark", "Soto", "Moses", "Rhodes", "Kane", "Cooper", "Hammond", "Fisher", "Nguyen", "Callahan", "Snow", "Bowers", "Tate", "Chapman", "Griffith", "Lin", "Patton", "Johnston", "Andersen", "Steele", "Hutchinson", "Castro", "Kirk", "Eaton", "Pope", "Dougherty", "Yang", "Church", "Bryant", "Chase", "Walker", "Schultz", "Stark", "Travis", "Rocha", "Santana", "Frazier", "Dalton", "Klein", "Booth", "Sosa", "Dean", "Ayers", "Vega", "Robles", "Carney", "Durham", "English", "Hurst", "Hudson", "Choi", "Sawyer", "Mercer", "Tanner", "Fischer", "Bradshaw", "Hays", "Wells", "Logan", "Khan", "Moody", "Page", "Henry", "Fox", "Guzman", "Cervantes", "Foley", "Allison", "Wiggins", "Vaughan", "Sherman", "Lynn", "Mcpherson", "Long", "Melton", "Peters", "Bass", "Fernandez", "Nichols", "Walsh", "Brady", "Rivas", "Marquez", "Glover", "Gates", "House", "Valdez", "Reyes", "Reeves", "Palmer", "Manning", "Howe", "Bender", "Frank", "Berger", "Rich", "Alexander", "Mitchell", "Hunt", "Warner", "Young", "Case", "Keith", "Ellis", "Whitehead", "Paul", "Nicholson", "White", "Dickson", "Snyder", "Bautista", "Cuevas", "Bullock", "Olsen", "Frederick", "Knapp", "Kidd", "Cruz", "Farmer", "Murphy", "Coleman", "Massey", "Clay", "Buck", "Vang", "Harvey", "Thompson", "Diaz", "Pittman", "Sparks", "Zamora", "Aguilar", "Oneill", "Pruitt", "Huber", "Ball", "Nielsen", "Macias", "Mcclure", "Hurley", "Hayes", "Rush" };
    }
}
