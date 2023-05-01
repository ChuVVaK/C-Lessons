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
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i= 1;i<=num;i++)
{
    Console.WriteLine($"{i} x {i} = {i*i}");
}
Console.WriteLine();
*/

//Task4. Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.

