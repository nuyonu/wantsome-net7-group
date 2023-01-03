using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.ExceptionsAndLinq.University
{
    public static class StorageHelper
    {
        public static List<Facultiy> Faculties { get; } = new List<Facultiy>();
    }

    public static class UniveristyManagement
    {
        public static void Run()
        {
            while (true)
            {
                RenderMenu();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    RenderFacultiesManagementMenu();
                }
            }
        }

        private static void RenderFacultiesManagementMenu()
        {
            throw new NotImplementedException();
            // 1. List all faculties
            foreach(Facultiy faculty in StorageHelper.Faculties)
            {
                Console.WriteLine(faculty.Name);
            }
            // 2. Add a faculity
            StorageHelper.Faculties.Add(new Facultiy());
            // 3. Remove a faculty
        }

        private static void RenderMenu()
        {
            Console.WriteLine("Choose from the following menu:");
            Console.WriteLine("1. Faculties management.");
            Console.WriteLine("2. Teachers management.");
        }
    }

    public class Person
    {

    }

    public class Teacher
    {

    }

    public class Student
    {

    }

    public class Facultiy
    {
        public bool Name { get; internal set; }
    }
}
