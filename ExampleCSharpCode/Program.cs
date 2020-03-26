using ExampleCSharpCode.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // create sample enrollment data
            var sampleData = new TestEnrollmentData().GetSampleData();
            Console.WriteLine("Creating sample student teacher data.");

            Console.WriteLine("");

            Console.WriteLine("STUDENT DATA");

            Console.WriteLine("");

            foreach (var student in sampleData.Students)
            {
                string output = student.GetStudentOutput();
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
