﻿/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
int GetCoordinate(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result !=0)
        {
            break;
        }
        else 
        {
            Console.WriteLine("ввели не число или некорректное число. Повторите ввод!\n");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int az, int bx, int by, int bz)
{
   double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));
   return result;
}

int ax = GetCoordinate("Введите х координату первой точки");
int ay = GetCoordinate("Введите у координату первой точки");
int az = GetCoordinate("Введите z координату первой точки");

int bx = GetCoordinate("Введите х координату второй точки");
int by = GetCoordinate("Введите у координату второй точки");
int bz = GetCoordinate("Введите z координату второй точки");

double distance = getDistance(ax, ay, bx, by, az, bz);

Console.WriteLine($"Расстояние между ({ax},{ay},{az}) и ({bx},{by},{bz}) {distance} ");