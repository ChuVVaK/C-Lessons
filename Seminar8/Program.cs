// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
*/
/*
void ReverseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j<array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array [j,i];
            array[j,i] = temp;
        }
    }
}

Console.WriteLine("Input quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
ReverseArray(myArray);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 < array.GetLength(0) && row2 < array.GetLength(0) && row1 >= 0 && row2 >= 0)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
        Show2dArray(array);
    }
    else Console.WriteLine("Sorry, I cannot. ");
}

Console.WriteLine("Chose row for change: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Chose row to change: ");
int row2 = Convert.ToInt32(Console.ReadLine());
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
ChangeRows(myArray, row1, row2);
*/

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int[] MinValue(int[,] array)
{
    int min = array[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
    int[] coord = { minRow, minColumn };
    Console.WriteLine ($"{minRow}, {minColumn}");

    return coord;
}

/*
void ZeroRowCol(int[,] array, int[] coord)
{

    for (int i = 0; i < array.GetLength(0); i++) array[i, coord[1]] = 0;
    for (int j = 0; j < array.GetLength(1); j++) array[coord[0], j] = 0;
}
*/
/*
int[,] DeleteRowCol(int[,] array, int[] coord)
{
    int[,] array1 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    
    for (int i = 0, n = 0; i < array.GetLength(0); i++, n++)
        {
        if (i == coord[0]) i++;
        else for (int j = 0, m = 0; j < array.GetLength(1); j++, m++)
            if (j == coord[1]) 
                    {
                        array1[n,m] = array[i,j+1];
                        j++;
                    }
                    else array1[n, m] = array[i,j];
        }
    return array1;

    // for (int i = 0; i < array.GetLength(0) - 1; i++)
    //     if (i == coord[0]) i++;
    //     else for (int j = 0; j < array.GetLength(1) - 1; j++)
    //     {
    //         if (j == coord[1]) array1[i, j] = array[i, j + 1];
    //         else array1[i, j] = array[i, j];
    //     }
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
int[] coord = MinValue(myArray);
// ZeroRowCol(myArray, coord);
int[,] newArr = DeleteRowCol(myArray, coord);
Show2dArray(newArr);
*/