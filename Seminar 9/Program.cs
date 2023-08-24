// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if (num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumOfDigits (int num)
{
    if (num !=0) return SumOfDigits(num/10) + num %10;
    return 0;
}

Console.WriteLine(SumOfDigits(123));
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*
void ShowNum(int m, int n)
{
    if (n > m) ShowNum(m, n - 1);
    if (n < m) ShowNum(m, n + 1);
    Console.Write(n + " ");
}

Console.WriteLine("Input argument M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input argument N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNum(n, m);
*/

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
int MultiplyNums(int a, int b)
{
    if (b != 0) return MultiplyNums(a, b - 1)*a;
    return 1;
}
Console.WriteLine (MultiplyNums(2, 5));
*/