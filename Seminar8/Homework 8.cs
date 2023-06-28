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

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void ArrangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int n = 0; n < array.GetLength(1) - 1; n++)
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n+1];
                    array[i, n+1] = array[i, n];
                    array[i, n] = temp;
                }
}

Console.WriteLine("Input quantity of rows in first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns in first matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
ArrangeRows(myArray); 
Show2dArray(myArray);
*/

//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int MinSumInd(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

void ShowMinRow(int[,] array, int minRow)
{
    Console.WriteLine($"Row with minimum summ of elements is: {minRow + 1}");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[minRow, j] + " ");
    }
}

Console.WriteLine("Input quantity of rows in first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns in first matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int minRow = MinSumInd(myArray);
ShowMinRow(myArray, minRow);
*/
//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MultipleArrays(int[,] array, int[,] array1)
{
    int[,] resultArray = new int[array.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
                sum += array[i, k] * array1[k, j];
            resultArray[i, j] = sum;
        }
    return resultArray;
}
Console.WriteLine("Input quantity of rows in first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns in first matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of rows in second matrix: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns in second matrix: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(firstArray);
int[,] secondArray = CreateRandom2dArray(rows1, columns1, minValue, maxValue);
Show2dArray(secondArray);
if (columns == rows1)
{
    int[,] resultArray = MultipleArrays(firstArray, secondArray);
    Show2dArray(resultArray);
}
else Console.WriteLine("This two matrix can not multple!");
*/
//  Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int rows, int columns, int page)
{
    int[,,] array = new int[rows, columns, page];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < page; k++)
            {
                array[k, i, j] = new Random().Next(10, 99 + 1);
            }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of page: ");
int page = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom3dArray(rows, columns, page);
Show3dArray(myArray);
*/
//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int k = 4;
int[,] spiralArray = new int[k, k];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralArray);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


