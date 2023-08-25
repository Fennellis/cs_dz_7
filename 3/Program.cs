// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 5; int n = 7;

int [,] arr = CreateArray(m, n, 0, 5);
PrintArray(arr);
PrintAverage(Average(arr));


int [,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 5}");
        Console.WriteLine();
    }
}

double[] Average(int[,] array)
{
    
    double[] sum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum[j] += array[i,j];
        sum[j] = Math.Round(sum[j] / array.GetLength(0), 1);
    }
    return sum;
}

void PrintAverage(double[] array)
{
    for (int i = 0; i <= array.GetLength(0)*5; i++)
        Console.Write("-");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i], 5}");
    }
}
