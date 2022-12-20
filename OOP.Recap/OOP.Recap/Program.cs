//Console.WriteLine(Math.Square(9));
//Console.WriteLine(Math.PI);
//Math.PI = 3;

//Console.WriteLine(Math.PI);

//public static class Math
//{
//    public static double PI { get; set; } = 3.14;

//    public static int Square(int x)
//    {
//        return x * x;
//    }
//}

using OOP.Recap;
using OOP.Recap.Inheritance;

//Student alexStudent = new Student("Alexandru", 1);
//alexStudent.Grades = new List<int>() { 5, 8, 10 };
//alexStudent.PrintInfo();

//Console.WriteLine(alexStudent.GetAverageForGrades(alexStudent.Grades));

//StudentHelper.PrintStudentInfo(alexStudent);

//BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

//myAccount.Deposit(500);
//myAccount.Withdraw(200);

//Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

//List<string> transactions = myAccount.GetTransactionHistory();
//foreach (string transaction in transactions)
//{
//    Console.WriteLine(transaction);
//}

///* Outputs:
//Deposited $500
//Withdrew $200
//*/

//myAccount.AccountNumber = 654321;
//myAccount.AccountHolder = "Jane Smith";

//Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
//Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith"

// Using static class:
//BankAccount alexAccount = new BankAccount("Alexandru", 100);
//Console.WriteLine($"{alexAccount.AccountHolder} {alexAccount.AccountNumber}");
//BankAccount alinAccount = new BankAccount("Alin", 100);
//Console.WriteLine($"{alinAccount.AccountHolder} {alinAccount.AccountNumber}");

Circle myCircle = new Circle(5);
Rectangle myRectangle = new Rectangle(5, 10);

//Console.WriteLine(myCircle.GetArea()); // Outputs 78.5398163397448
//Console.WriteLine(myCircle.GetPerimeter()); // Outputs 31.4159265358979

//Console.WriteLine(myRectangle.GetArea()); // Outputs 50
//Console.WriteLine(myRectangle.GetPerimeter()); // Outputs 30

List<Shape> shapes = new List<Shape>() { myCircle, myRectangle };
foreach (var shape in shapes)
{
    if (shape.GetType() == typeof(Circle))
    {
        Console.WriteLine("Yes");
    }
    Console.WriteLine(shape.GetType());
    Console.WriteLine(shape.GetArea());
    Console.WriteLine(shape.GetPerimeter());
}