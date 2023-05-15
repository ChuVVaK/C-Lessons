//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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
/*
void ReversArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i<j; i++, j--)
    {
        int temp = array[i];
        array[i]=array[j];
        array[j] = temp;
    }
}
*/
/*
Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);
*/
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{   if ((a + b)>= c & (a+c) >= b & (c+b) >= a);
    {
        Console.WriteLine("You can't create triangle!");
        return false;
    }

    else Console.WriteLine("You can create triangle with this numbers");
    return true;
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());
Triangle(a, b, c);
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] FibonacciSeries (int size)
{
    int [] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i=2; i<size; i++)
        array[i]=array[i-2]+array[i-1];
    return array;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(FibonacciSeries(size));
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] CopyArray(int [] array)
{
    int[] array1 = new int [array.Length];
    for (int i=0; i<array.Length; i++)
        array1[i]=array[i];
    return array1;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ShowArray(CopyArray(myArray));
*/