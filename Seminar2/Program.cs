// Seminar 2.

// Task 1. Программа которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int result = hundreds * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
//Next учитывает нижний предел, а верхний игнорирует
int shortNumber = CutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {shortNumber}");
*/

/*
bool IsEven(int num)
{
    if (num % 2 == 0)
        return true;
    else
        return false;
}

bool result = IsEven(7);
Console.WriteLine (result);
*/

//Task 2. Программа, которая выводит случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа
/*
int MaxDigits (int ranNumber)
{
    int dozens = ranNumber/10;
    int units = ranNumber %10;
    if (units => dozens) return units;
    else return dozens;
}
int random = new Random().Next(10, 100);
int randomNumber = MaxDigits(random);
Console.WriteLine(random);
Console.WriteLine(randomNumber);

*/

//Task 3. Программа, которая будет принимать на вход два числа и выводить, является ли второе число
//кратным первому.
/*
bool Even (int num1, int num2)
{
    if (num2%num1 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

bool result = Even (num1, num2);
Console.WriteLine(result);
*/

//Task 4. Программа, которая принимате на вход число n и проверяет, кратно ли оно 
//одновременно a и b
/*

bool Even(int num, int divA, int divB)
{
    if (num % divA == 0 && num%divB == 0) return true;
    else return false;
}

Console.WriteLine("Input a first number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int divA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a third number: ");
int divB = Convert.ToInt32(Console.ReadLine());

bool result = Even(num, divA, divB);
Console.WriteLine(result);
*/

//Task 5. Программа, которая принимает на вход 2 числа и проверяте является ли одно 
//число квадратом другого.
/*
bool Quad (int num1, int num2)
{
    if (num1 == num2*num2 || num2 == num1*num1) return true;
    else return false;
}
Console.WriteLine("Input a first number: ");
int num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Quad (num1, num2);
Console.WriteLine (result);
*/