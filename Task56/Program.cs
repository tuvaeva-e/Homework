/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = (i+j);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int ReturnRowNumber(int[,] matrix)
{
    int rowIndex = 0;
    int rowSum = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum = rowSum + matrix[i,j];
        }
        if(rowSum < minSum)
        {
            minSum = rowSum;
            rowIndex = i;
        }
    }

    return rowIndex;
}

int rows = GetNumber("Введите кол-во строк:");
int columns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

int rowMinSumm=ReturnRowNumber(matrix);
Console.WriteLine($"Номер строки с минимальной суммой: {rowMinSumm}");