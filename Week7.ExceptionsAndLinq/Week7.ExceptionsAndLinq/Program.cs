using Week7.ExceptionsAndLinq;

// Exercise 8:
// Given a list of integers, use LINQ to compute the sum of the squares of the even numbers in the list.
// Hint: Where, Sum, Select

// 1 2 3 => 1 + 4 + 9 = 14

//var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Console.WriteLine(numbers.Sum(x => x * x));

DemoLINQ.Run();

// Immediate execution LINQ
//var numbers = new List<int>() { 1, 2, 3, 4 };

//var query = numbers.Where(number => number % 2 == 0).ToList(); // Aici SELECT * FROM ...

//numbers.Add(6);

//var query2 = query.Select(number => number * 2); // Peste lista incarcata in memorie

//foreach(var number in query2)
//{
//    Console.WriteLine(number);
//}

// Deferred execution LINQ -> 4 8 12
//var numbers = new List<int>() { 1, 2, 3, 4 };

//var query = numbers.Where(number => number % 2 == 0); // AICI nu se incarca nimic

//numbers.Add(6);

//query = query.Select(number => number * 2); // Aici SELECT * FROM ...

//foreach (var number in query)
//{
//    Console.WriteLine(number);
//}






//Console.WriteLine(IsPalindrom("ana"));
//Console.WriteLine(IsPalindrom("abca"));

//bool IsPalindrom(string input) // ana -> a = a n = n abccba // 3
//{
//    int length = input.Length;

//    for(int index = 0; index < length / 2; index++)
//    {
//        if (input[index] != input[length - index - 1])
//        {
//            return false;
//        }
//    }

//    return true;
//}

//Console.WriteLine(SumThreeNumbers(1,2,3));

//Func<int, int, int, int> sumThreeNumbers = (a, b, c) => a + b + c;

//Console.WriteLine(sumThreeNumbers(1, 2, 3));

//int SumThreeNumbers(int a, int b, int c)
//{
//    return a + b + c;
//}

//var anonymous = new { Name = "Alex", Age = 13, CNP = "123213123" };

//Console.WriteLine(anonymous.Name);
//Console.WriteLine(anonymous.Age);
//Console.WriteLine(anonymous.CNP);

//UniveristyManagement.Run();
//Exceptions.Run();
//new EmailsChecker().ReadAndCheckEmails();

// Catch vs multiple exceptions catch

//WorkWithFiles.Run();

//Console.WriteLine(5.Square());
//Console.WriteLine(IntExtensions.SquareWithoutExtension(5));

public static class IntExtensions
{
    public static int Square(this int number)
    {
        return number * number;
    }

    public static int SquareWithoutExtension(int number)
    {
        return number * number;
    }
}

// IsPalindrom : string => TRUE if string is palindrom or FALSE if not -> aceeca, ana,