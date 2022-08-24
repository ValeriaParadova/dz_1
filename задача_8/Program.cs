// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Первый способ решения задачи:

// Console.Write("Enter number : ");

// int number = Convert.ToInt32(Console.ReadLine());

// int i = 2;

//     while (i <= number)
// {
//     if (i % 2 == 0)
// {
//  Console.Write(i + " ");

// }
// i++;
// }


// Второй способ решения задачи через цикл for:

// Console.Write("Enter number : ");
// int Number1 = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i <= Number1; i+=2 )
// {
// Console.Write(i);
// }

// Третий способ решения задачи через цикл for:

Console.Write("Enter number : ");
int Number1 = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= Number1; i+=2 )
{
    System.Console.Write(i+ " ");
}
for (int i = 1; i <= Number1; ++i)
{
    if (i % 2 == 0) System.Console.Write(i + " ");
}