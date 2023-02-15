/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] ReturnResultMatrix(int[,] matrixOne, int[,] matrixTwo)
{

    int[,] matrixResult = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrixResult[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }

    return matrixResult;
}

bool CheckIfCanMultiple(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne.GetLength(1) == matrixTwo.GetLength(0)) return true;
    else return false;
}

int rowNumberFirst = GetNumber("Введите количество строк 1 матрицы:");
int columnNumberFirst = GetNumber("Введите количество столбцов 1 матрицы:");
int rowNumberSecond = GetNumber("Введите количество строк 2 матрицы:");
int columnNumberSecond = GetNumber("Введите количество столбцов 2 матрицы:");
int[,] matrixNewFirst = InitMatrix(rowNumberFirst, columnNumberFirst);
int[,] matrixNewSecond = InitMatrix(rowNumberSecond, columnNumberSecond);
PrintMatrix(matrixNewFirst);
Console.WriteLine();
PrintMatrix(matrixNewSecond);
if (CheckIfCanMultiple(matrixNewFirst, matrixNewSecond)) {
    int[,] matrixMiltipliedMatrexes=ReturnResultMatrix(matrixNewFirst, matrixNewSecond);
    Console.WriteLine("Результат:");
    PrintMatrix(matrixMiltipliedMatrexes);
}
else Console.WriteLine("Перемножить данные матрицы невозможно.");