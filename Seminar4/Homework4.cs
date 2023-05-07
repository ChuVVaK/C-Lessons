//Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int MathPow(int numA, int numB)
{
    int temp = numA;

    for (int count = 1; count != numB; count++)
    {
        temp *= numA;
    }
    return temp;
}

bool ValidNumB (int numB)
{
    if (numB<0)
    {
        Console
    }
}
Console.WriteLine("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int res = MathPow(numA, numB);
Console.WriteLine($"{res}");
*/

//Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits (int number)
{
    int sum = 0;
    while (number>0)
    {
        sum += number%10;
        number /=10;
    }
    return sum;
}

int sum = SumDigits(number);
Console.WriteLine($"Your number is {number}, sum of digits is {sum}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void FillArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index<length)
    {
        array [index] = new Random().Next(1,100); 
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position<count-1)
    {
        Console.Write(col[position] + ",");
        position++;
    }
    Console.Write($"{col[position-1]}");
    Console.WriteLine("]");
}

int [] array = new int [new Random().Next(1,9)];
FillArray(array);
PrintArray(array);
*/