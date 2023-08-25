// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int m = 5; int n = 3;

int [,] arr = CreateArray(m, n, 0, 5);
PrintArray(arr);

Console.Write("Введите номер столбца: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int y = Convert.ToInt32(Console.ReadLine());

int? result = IsExist(arr, x, y);
if (result != null) Console.WriteLine($"{result}");
else Console.WriteLine("Указанного элемента не существует");

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

int? IsExist(int[,] array, int columns, int rows)
{
    if (rows <= array.GetLength(0) && columns <= array.GetLength(1))
        return array[rows - 1,columns - 1];
    else return null;
}
