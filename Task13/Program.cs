/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetArrayNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = GetArrayNumber();

if(number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine (result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}