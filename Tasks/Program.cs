﻿/* 
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




