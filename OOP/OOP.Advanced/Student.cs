using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced
{
    public class Student
    {
        public string[] courses;

        public List<string> courses2;

        public Student()
        { }

        public Student(string[] courses)
        {
            this.courses = courses;
        }

        public Student(List<string> courses)
        {
            this.courses2 = courses;
        }

        public void PrintCourses()
        {
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }

        public void PrintCourses2()
        {
            foreach (var course in courses2)
            {
                Console.WriteLine(course);
            }
        }
    }
}
