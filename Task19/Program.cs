/* Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int GetNumber(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber > 9999 && resultNumber < 100000)
        {
            break;
        }
        else 
        {
            Console.WriteLine("ввели не число или не корректное число. Повторите ввод!\n");
        }
    }
    return resultNumber;
}
int resultNumber = GetNumber("Введите пятизначное число");

    if (resultNumber % 2 == resultNumber / 10000 && (resultNumber%100)/10 == (resultNumber/1000)%10)
    {
        Console.WriteLine($"{resultNumber} это палиндром");
    }
    else
    {
        Console.WriteLine($"{resultNumber} это не палиндром");
    }