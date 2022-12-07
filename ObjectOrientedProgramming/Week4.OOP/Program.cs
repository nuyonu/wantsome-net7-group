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

Employee emanuela = new Employee("Emanuela", 30, 8000, "CEO");
emanuela.abilities = "Self-Learner";
Console.WriteLine(emanuela.abilities.ToLower());
Console.WriteLine(emanuela.GetDetails());