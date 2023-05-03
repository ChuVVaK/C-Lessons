//Task 19. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int revers = 0;
while (num>0)
{
    int rem = num%10;
    revers = revers*10+rem;
    num = num/10;
}
if (temp == revers) Console.WriteLine("Your number is palindrome!");
else Console.WriteLine("Your number is not palindrome!");
*/

//Task 21. Напишите программу, которая принимает на вход координаты двух точек и находи расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Input first point coordinate X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first point coordinate Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first point coordinate Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second point coordinate X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second point coordinate Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second point coordinate Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceBetween(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int catet1 = x2 - x1;
    int catet2 = y2 - y1;
    int catet3 = z2 - z1;
    double distance = Math.Sqrt((catet1 * catet1 + catet2 * catet2)+catet3*catet3);
    return distance;
}
double distance = Math.Round(DistanceBetween(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Distance between poin A and B is: {distance}");
*/

//Task 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
/*
void TablCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i * i * i}");
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
TablCube(num);
*/