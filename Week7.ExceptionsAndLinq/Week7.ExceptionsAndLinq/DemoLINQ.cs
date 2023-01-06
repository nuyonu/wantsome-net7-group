namespace Week7.ExceptionsAndLinq
{
    public static class DemoLINQ
    {
        public static void Run()
        {
            var employees = new List<Employee>
            {
                new Employee("Alex", 20, 3000),
                new Employee("Florin", 34, 3300),
                new Employee("Andrei", 23, 2800),
                new Employee("Daniel", 55, 4300),
                new Employee("Radu", 19, 3500),
                new Employee("Adrian", 45, 7300),
                new Employee("Pepe", 32, 6500),
            };

            var result = employees.Where(employee => employee.Age < 45)
                .OrderByDescending(employee => employee.Salary)
                .Select(employee => new EmployeeSmallInfo { Name = employee.Name })
                .ToList();

            foreach (var employeeSmallInfo in result)
            {
                Console.WriteLine(employeeSmallInfo.Name);
            }
        }
    }

    public class EmployeeSmallInfo
    {
        public string Name { get; set; }
    }

    public class Employee
    {
        public Employee(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }
    }
}
