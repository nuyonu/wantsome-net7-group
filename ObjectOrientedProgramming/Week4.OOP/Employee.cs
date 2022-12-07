namespace Week4.OOP
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        public string abilities;
        public double salary;
        public string function;

        public Employee()
        {
            this.name = "Gigi";
            this.age = 0;
            this.id = 0;
            this.salary = 0;
            this.function = "unknown";
        }

        public Employee(string name, int age, double salary, string function)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.function = function;
        }

        public string GetDetails()
        {
            string details = $"Numele este {this.name}, varsta este {this.age}, salariul este {this.salary}, functia este {this.function}";

            return details;
        }
    }
}
