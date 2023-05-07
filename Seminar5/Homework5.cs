//Task 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
*/
/*
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/
/*
int CheckEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
*/
/*
Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value. Value must be positive three digit number: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value. Value must be positive three digit number: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

if (minValue>=100 && minValue<1000 && maxValue>=100 && maxValue<1000) 
{
    int[] myArray = CreateRandomArray(size, minValue, maxValue);
    ShowArray(myArray);
    Console.WriteLine("The quantity of even numbers is: "+ CheckEven(myArray));
}
else Console.WriteLine("Your value is incorrect!");
*/

//Task 36. Задайте одномерный массив, заполненный случайныыми числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumOddInd (int[] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i = i+2) sum += array[i];
    return sum;
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
Console.WriteLine("The sum of numbers in odd position is "+ SumOddInd(myArray));
*/
//Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива. 
//тип массива doble 
/*
double[] FillArray(int size)
{
    double[] array = new double[size];
    int i = 0;
    while (i < size)
    {
        Console.Write($"Input number {i + 1}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        i++;
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double CheckDiffMinMax(double[] array)
{

    double min = array[1];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
        if (array[i]>max) max = array[i];
        else if (array[i]<min) min = array[i];
    double diff = max - min;
    return diff;
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = FillArray(size);
ShowArray(myArray);
Console.WriteLine($"The difference between max and min value is: "+ CheckDiffMinMax(myArray));
*/