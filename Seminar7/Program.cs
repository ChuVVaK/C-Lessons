//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

/*
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
*/

// Задача 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.

/*
int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i+j;
    return array;
}

Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns);
Show2dArray(myArray);
*/
// Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*
int [,] EvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i +=2)
        for (int j = 0; j < array.GetLength(1); j +=2)
            if (i==j) array[i, j] *= array[i, j];
    return array;
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
EvenIndex(myArray);
Show2dArray(myArray);
*/

// Задача 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int MainDiagSumm(int[,] array)
{
    int summ = array[0, 0];
    for (int i = 1; i < array.GetLength(0) && i < array.GetLength(1); i++)
        summ += array[i, i];
    return summ;
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
Console.WriteLine($"The summ is: {MainDiagSumm(myArray)}");
*/
