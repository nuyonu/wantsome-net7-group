using OOP.Advanced;

//string[] coursesForAlex = new string[3] { "Math", "Example", "AnotherExample" };
//Student alex = new Student(coursesForAlex);

//alex.PrintCourses();

//List<string> flaviaCourses = new List<string>() { "Math", "Example", "AnotherExample" };
//Student flavia = new Student(flaviaCourses);

//flavia.PrintCourses2();

//// SAU

//Student sorin = new Student(new List<string>() { "Math", "Example", "AnotherExample" });

//sorin.PrintCourses2();

//// SAU

//List<string> laurentiuCourses = new List<string>();
//laurentiuCourses.Add("Math");
//laurentiuCourses.Add("Example");
//laurentiuCourses.Add("AnotherExample");

//Student laurentiu = new Student(laurentiuCourses);

//laurentiu.PrintCourses2();

//Teacher teacher = new Teacher();
//teacher.name = "Alex";
//teacher.password = "Parola";
//teacher.SetSalary(100);

//Account alexAccount = new Account();
//alexAccount.balance = 100_000;
//alexAccount.balance = 90_000;
//alexAccount.balance -= 110_000;
//alexAccount.AddBalance(10_000);
//Console.WriteLine(alexAccount.Balance);
//alexAccount.Balance = -10;
//alexAccount.AddBalance(-10_000);

//Teacher teacher = new Teacher();
//teacher.Name = "Alex";
//teacher.Email = "alex@email.com";
//teacher.SetSalary(100);

//Account alexAccount = new Account()
//{
//    Balance = 10_000 // CTRL + SPACE pentru Visual Studio
//};

//Account example = new Account
//{
//    Balance = 20_000,
//    Example = 20
//};

//// EQUAL

//Account alexAccount = new Account();
//alexAccount.Balance = 10_000;

//List<string> myList = new List<string> { "Example", "Example2", "Example3" };

//Author alexAuthor = new Author("Alex");
//Console.WriteLine(alexAuthor.Name);

// OR

//Author alexAuthor2 = new Author();
//alexAuthor2.SetName("Alex2");
//Console.WriteLine(alexAuthor2.Name);

// OR

//Author alexAuthor3 = new Author();
//alexAuthor3.Name = "Alex3";
//Console.WriteLine(alexAuthor3.Name);

//Author alexAuthor3 = new Author();
//alexAuthor3.SetName("Alex3");
//alexAuthor3.Email = "alex@email.com";
//Console.WriteLine(alexAuthor3.GetName());
//Console.WriteLine(alexAuthor3.Email);

AudiVehicle audi = new AudiVehicle
{
    Color = "white",
    Name = "A3",
    NumberOfWheels = 5
};

audi.Start();

FordVehicle ford = new FordVehicle();
ford.Start();