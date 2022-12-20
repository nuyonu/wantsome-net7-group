using System.Xml.Linq;

namespace OOP.Recap
{
    public interface IPerson
    {
        public int Id { get; set; }

        public int GetId();
    }

    public abstract class Person : IPerson
    {
        public Person(int id, PersonType personType)
        {
            Id = id;
            PersonType = personType;
        }

        public int Id { get; set; }

        public PersonType PersonType { get; set; }

        public virtual int GetId()
        {
            return Id;
        }
    }

    public sealed class Student : Person
    {
        // Acess modifiers:
        // public
        // private
        // protected
        // internal

        // Fields
        private string name;

        // Constructors
        public Student(string name, int id) : base(id, PersonType.Student)
        {
            this.Name = name;
        }

        // Methods
        public double GetAverageForGrades()
        {
            int counter = 0;
            int sum = 0;

            foreach(int grade in Grades)
            {
                sum += grade;
                counter++;
            }

            return sum / counter;

            // OR
            // return GetAverageForGrades(this.Grades);
        }

        public double GetAverageForGrades(List<int> grades)
        {
            int counter = 0;
            int sum = 0;

            foreach (int grade in grades)
            {
                sum += grade;
                counter++;
            }

            return sum / counter;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student name: {Name}, average grades: {GetAverageForGrades()}");
        }

        public override int GetId()
        {
            return this.Id;
        }

        // Properties
        public List<int> Grades { get; set; }

        public string Name { 
            get 
            { 
                return this.name; 
            } 
            set 
            {
                if (value.Length < 5)
                {
                    throw new Exception("Name cannot be smaller than 5.");
                }
                else
                {
                    this.name = value;
                }
            } 
        }
    }

    public enum PersonType
    {
        None = 0,
        Student = 1,
        Teacher
    }

    public static class StudentHelper
    {
        public static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"Student name: {student.Name}, average grades: {student.GetAverageForGrades()}");
        }
    }
}
