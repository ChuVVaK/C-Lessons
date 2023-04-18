// Задача 2. Напишите программу, которая на вход принимает два числа и выдет, какое
//число больше, а какое меньше.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2) 
{
    Console.WriteLine("Max = " + num1);
}

else 
{
    Console.WriteLine("Max = " + num2);
}
*/

//Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное
//из этих чисел.

/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max) max = num2;
if (num3>max) max = num3;

Console.WriteLine("Max = " + max);
*/

//Задача 6. Напишите программу, которая на вход принимает число и выдет, является ли
//число чётным.

/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) 
{
    Console.WriteLine("Yes!");
} 
else
{
    Console.WriteLine("No!");
}
*/

//Задача 8. Напишите программу, которая на вход принимает число (N), а на входе
// показывает все чётные числа от 1 до N

/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current<=num)
{
    if (current % 2 ==0) Console.Write(current + " ");
    current++;
}
*/