using Week4.OOP;

//House house = new House();
//house.name = "MyHouse";
//house.nrOfWindows = 12;
//house.nrOfDoors = 5;

//Console.WriteLine($"Name: {house.name}, Number of windows: {house.nrOfWindows}, Number of doors: {house.nrOfDoors}");

//int temp = house.GetNumberOfDoorsMinusOne();

//Console.WriteLine(temp);

//Console.WriteLine(house.GetNumberOfDoorsMinusOne());

//House house = new House();
//house.name = "MyHouse2";

//Console.WriteLine($"Name: {house.name}, Number of windows: {house.nrOfWindows}, Number of doors: {house.nrOfDoors}");

//House house2 = new House("MyHouse3");
//Console.WriteLine($"Name: {house2.name}, Number of windows: {house2.nrOfWindows}, Number of doors: {house2.nrOfDoors}");

//House house3 = new House(house2);
//Console.WriteLine($"Name: {house3.name}, Number of windows: {house3.nrOfWindows}, Number of doors: {house3.nrOfDoors}");


//Employee alex = new Employee();
//Console.WriteLine(alex.GetDetails());

//Employee emanuela = new Employee("Emanuela", 30, 8000, "CEO");
//emanuela.abilities = "Self-Learner";
//Console.WriteLine(emanuela.abilities.ToLower());
//Console.WriteLine(emanuela.GetDetails());

//Address alexAddress = new Address();
//alexAddress.state = "Romania";
//alexAddress.city = "Iasi";
//alexAddress.streetNumber = 15;
//alexAddress.street = "Strada Arcu";

//Address marianAddress = new Address();
//marianAddress.state = "Romania";
//marianAddress.city = "Iasi";
//marianAddress.streetNumber = 15;
//marianAddress.street = "Soseaua Arcu";

//Person alex = new Person("Alex", "Grigoras", 24, "male", marianAddress);
//alex.Introduce();

//Console.WriteLine(alex.GetAgePlusTen());

// Exercise 1:
// Author -> firstName, lastName, middleName -> constructor
// Book -> title, year, genre, author: Author -> constructor

// GetTitle() -> title
// PrintInfo() - afiseaza la consola "Book: title = <TITLE>, year = <YEAR>, genre = <GENRE> and Author is <FIRSTNAME> <MIDDLENAME> <LASTNAME>."

Author ionCreanga = new Author("Ion", "Creanga", "Gigi");
Book amintiriDinCopilarie = new Book("Amintiri din copilarie", 1983, "Roman", ionCreanga);
amintiriDinCopilarie.PrintInfo();
// SAU
Book amintiriDinCopilarie2 = new Book("Amintiri din copilarie", 1983, "Roman", new Author("Ion", "Creanga", "Gigi"));
amintiriDinCopilarie2.PrintInfo();

// Exercise 2:
// Create a class Course with the following fields:
// courseName
// courseCode
// teacherName

// Create a class Student with the following fields:
// firstname
// lastName
// age
// gender
// grades - an array of integers
// Course

// Add the following methods for Student:
// GetGrades() - get all grades
// GradeAverage() - return the average of grades (WHEN IMPLEMENT THIS METHOD, CALL THE METHOD GetGrades());
// UpdateCourse(Course) - update the current course with the new one received as parameter