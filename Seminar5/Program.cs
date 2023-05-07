/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
*/
//Task 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int GetSumOfNegatives(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine("Sum of negative elements is" + GetSumOfNegatives(myArray));
*/

//Task 2. Напишите программу которая задает массив и меняет отрицательные числа на положительные и наоборот.
/*
int[] MakePositiveNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}
Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
MakePositiveNegative(myArray);
ShowArray(myArray);
*/

//Task 3. Задайте массив. Напишите программу которая определяет, присутствует ли заданное число в массиве.
/*
bool CheckNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine("There is such number in the current array");
            return true;
        }
    }
    Console.WriteLine("There is no such number in the current array.");
    return false;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a chosen number: ");
int chosen = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine(CheckNumber(myArray, chosen));
*/
//Task 4. Задайте одномерный массив из M случайных чисел. Найдите количество элементов массива, значение которых лежат в отрезке [a,b]
/*
int CountNumber(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= a && array[i] <= b) count++;
    return count;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input lower border: ");
int boarderA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input top border: ");
int boarderB = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine("The quantity of elements between boarders:" + CountNumber(myArray, boarderA, boarderB));
*/