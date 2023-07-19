/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите целое число: ");
int b = int.Parse(Console.ReadLine()!);
int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите целое число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите целое число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 2;
while (start < N-1)
{
    Console.Write(start+", ");
    start += 2;
}
if ((N-1) % 2 == 0)
{
    Console.Write(N-1);
}
if (N % 2 == 0)
{
    Console.Write(N);
}