// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number : ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number : ");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number : ");

int number3 = Convert.ToInt32(Console.ReadLine());

int MaxNumber = number1;

if (number2 > MaxNumber)

{
    MaxNumber = number2;
}

if (number3 > MaxNumber)
{
    MaxNumber = number3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + MaxNumber);
        
