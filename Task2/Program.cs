﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите перое число: ");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число: ");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
int max = a;
if (max > b ) max = a;
if (b > max ) max = b;

Console.Write("max = ");
Console.WriteLine(max);