//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().NextDouble();
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next();
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElement(int[,] array, int i, int j)
{
    if (i > array.GetLength(0) || j > array.GetLength(1)) Console.WriteLine("Индекс находится за пределами массива.");
    else Console.WriteLine($"Число с индексом {i}, {j} = {array[i, j]}");
}
Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);

Console.WriteLine("Input first index: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second index: ");
int j = Convert.ToInt32(Console.ReadLine());

ShowElement(myArray, i, j);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] SumColumns(int[,] array)
{
    double[] arr = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    arr[j] = Math.Round(sum/array.GetLength(0),2);
    }
    return arr;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
double [] array = SumColumns(myArray);
ShowArray(array);
*/