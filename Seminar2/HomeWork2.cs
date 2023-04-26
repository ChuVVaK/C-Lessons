//Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ChooseDozens(int num)
{
    int result = num % 100 / 10;
    return result;
}

Console.WriteLine("Inpute three-digit number: ");
int num = Convert.ToInt32 (Console.ReadLine());
int result = ChooseDozens (num);
Console.WriteLine (result);
*/

//Task 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int number)
{
    int result = -1;
    if (number >=100)
    {
        while (number > 999)
            {
                number = number / 10;
            }
        result = number % 10;
    }
    return result;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number) == -1)
Console.WriteLine("Thrid digit is missing!");
else
Console.WriteLine($"Third digit is {ThirdDigit(number)}");
*/

//Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine ("Input a number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7) Console.WriteLine("Yes!");
if (num < 1 || num > 7) Console.WriteLine ("Incorrect number!");
else Console.WriteLine("No!");
*/