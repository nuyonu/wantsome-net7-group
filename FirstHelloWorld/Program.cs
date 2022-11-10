// See https://aka.ms/new-console-template for more information

// 10 + 20
// x + 10

// TYPE NAME = EXPRESSION
//int number = 100.0;

// int - numere fara virgula
// byte - 0 - 255
// long - numere foarte mari fara virgula
// float - numere cu virgula
// double - numere cu virgula
// char - caractere
// bool - True (1) sau False (0)
// string - siruri de caractere
// DateTime - data

//float number2 = 100.5;

//char character = 'a';
//string myName = "Alex";

//Console.WriteLine(number2);

//Console.WriteLine($"byte Store numbers between Min: {byte.MinValue} Max: {byte.MaxValue}");
//Console.WriteLine($"int Store numbers between Min: {int.MinValue} Max: {int.MaxValue} [store");
//Console.WriteLine($"long Store numbers between Min: {long.MinValue} Max: {long.MaxValue}");
//Console.WriteLine($"float Store fractional numbers between Min: {float.MinValue} Max: {float.MaxValue}");
//Console.WriteLine($"double Store fractional numbers between Min: {double.MinValue} Max: {double.MaxValue}");

//int firstNumber = 5;
//int secondNumber = 6;

//int sum = firstNumber + secondNumber;

// char -> int -> long -> float -> double
// double -> float -> long -> int -> char


//int myNumber = 100;
//long myNumberLong = myNumber;

//double number = 900;
//int result = (int)number;

//Console.WriteLine(result);

// Console.ReadLine() -> citi input de la utilizator


//Console.WriteLine("Care este numele tau?");
//string name = Console.ReadLine();
//Console.WriteLine("Salut " + name);

//Console.WriteLine("Care este varsta ta?");

//string input = Console.ReadLine();
//int age = Convert.ToInt32(input);
//Console.WriteLine("Varsta introdusa este " + age);


// + Addition
// - Substraction
// * Multiplication
// / Division
// ++ Increment
// -- Decrement
// % Modulus

//int sum = 5 + 10;
//double firstNumber = 10;
//double secondNumber = 3;
//double division = firstNumber / secondNumber;

//Console.WriteLine(division);

//int number = 5;
//int secondNumber = number--;

//Console.WriteLine(secondNumber);

//int result = 10 % 3; // restul impartirii lui 10 la 3

//Console.WriteLine(result);

//int x = 4;
//x = x + 5;
//// x = 4 + 5;
//x += 5; // echivalent cu linia 88
//x /= 3;

//// == Equal to
//Console.WriteLine(5 == 5);
//Console.WriteLine(5 == 6);
//// != Not Equal
//Console.WriteLine(5 != 5);
//Console.WriteLine(5 != 6);
//// > Greater than
//Console.WriteLine(5 > 4);
// < Less than
// >= Greater or equal to
// <= Less or equal to

// && Logical and
// || Logical or
// ! Logical not

//Console.WriteLine(6 > 5 && 3 > 2); // True && True => True

//var CONDITIE = true;

//if (CONDITIE)
//{
//    // Codul de aici se executa daca conditia este adevarata
//}

//Console.WriteLine("Introdu varsta");

//int age = Convert.ToInt32(Console.ReadLine());
//int childAge = Convert.ToInt32(Console.ReadLine());

//if (age < 90 && childAge > 25)
//{
//    Console.WriteLine("Te primim in grup");
//}
//else
//{
//    // Codul de aici se executa cand conditia este falsa
//    Console.WriteLine("Nu te primim in grup.");
//}

//if (age < 90 && childAge > 25)
//{
//    Console.WriteLine("Te primim in grup");
//}
//else if (age > 90 && age < 100)
//{
//    // Codul de aici se executa cand conditia din al doilea if este adevarata
//    Console.WriteLine("Poti incerca la anul.");
//}
//else
//{
//    // Codul de aici se executa cand conditia din al doilea if este falsa
//}

int day = 6;

if (day == 1)
{
    Console.WriteLine("Luni");
}
else if (day == 2)
{
    Console.WriteLine("Marti");
}
else if (day == 3)
{
    Console.WriteLine("Miercuri");
}
else if (day == 4)
{
    Console.WriteLine("Joi");
}
else
{
    Console.WriteLine("Ziua nu exista");
}

switch (day)
{
    case 1:
        Console.WriteLine("Luni");
        break;
    case 2:
        Console.WriteLine("Marti");
        break;
    case 3:
        Console.WriteLine("Miercuri");
        break;
    case 4:
        Console.WriteLine("Joi");
        break;
    default:
        Console.WriteLine("Ziua nu exista");
        break;
}