/*Задача 68: Напишите программу вычисления функции Аккерман 
m = 3, n = 2 -> A(m,n) = 29*/ 

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите вввод ");
        }
    }
    return result;
}

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
    return Akkerman(n - 1, 1);
  else
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

int numM = GetNumber("Введите число m: ");
int numN = GetNumber("Введите число n: ");
Console.WriteLine($"значение функции Аккермана при m = {numM}, n = {numN}: {Akkerman(numM, numN)}");