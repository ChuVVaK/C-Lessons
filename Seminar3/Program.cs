//Task1. Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowRange(int quad)
{
    if (quad==1) Console.WriteLine("x>0 and y>0");
    else if(quad==2) Console.WriteLine("x<0 and y>0");
    else if (quad == 3) Console.WriteLine("x<0 and y<0");
    else if (quad == 4) Console.WriteLine ("x>0 and y<0");
    else Console.WriteLine("Wrong number of quadrant!");
}

Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);
*/

//Task2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int ShowQuadrant (int x, int y)
{
    int quad = 0;
    if (x==0 && y==0) quad = 0;
    else if (x>0)
        {
            if (y>0) quad = 1;
            else quad = 4;
        }
        else
        {
            if (y>0) quad = 3;
            else quad = 2;
        }
        return quad;
}

Console.WriteLine("Input coordinat x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinat y: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = ShowQuadrant(x,y);
if (result == 0) Console.WriteLine ("You input zero point!");
else Console.WriteLine($"Number of the quadrant is {result}");
*/

//Task3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.

/*
void TablKvad(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} x {i} = {i * i}");
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
TablKvad(num);
*/


//Task4. Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.
/*
Console.WriteLine("Input first point coordinates: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second point coordinates: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double DistanceBetween(int x1, int x2, int y1, int y2)
{

    int catet1 = x2 - x1;
    int catet2 = y2 - y1;
    double distance = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
    return distance;
}
double distance = Math.Round(DistanceBetween(x1, x2, y1, y2),2);
Console.WriteLine($"Distance between poin A and B is: {distance}");
*/
