/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int [] InitArray(int dimension)
{
    int [] arr = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetDifMinMax(int[] array)
{
    int result = 0;
    int minNumber = array[0];
    int maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(minNumber > array[i])
          minNumber = i;
        else if (maxNumber < array[i])
          maxNumber = i;
    }
      result = maxNumber - minNumber;
    return result;
}

int[] array = InitArray(5);
PrintArray(array);
int diff = GetDifMinMax(array);
Console.WriteLine($"разница между минимальным и максимальным элементом массива= {diff}");
