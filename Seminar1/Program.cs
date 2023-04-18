/*
int num1 = 5;
double num2 = 2.34;

string world = "Good morning! 893457983(*&^(*&^))"; //Обязательно в кавычках!!!
bool check = true;
*/

//Ctrl+/ - закоментирует всю выделенную область. 
//Флаги начала и конца коментирования "/*" - все строки ниже коментируется 
//"*/" - конец коментирования

/*
int num1 = 5;
int num2 = 8;

Console.WriteLine("My numbers are " + num1 + " and " + num2 + " and it is good!"); 
- конкатенация
Console.WriteLine($"My numbers are {num1} and {num2} and it is good!"); 
- форматный вывод
*/

//конкатенацию лучше использовать, если переменная в начале или в конце строки.
//форматный вывод лучше исользовать, если переменные "{num1} и т.д." находятся в середине текста

/*
Console.Write("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is "+ num);
*/

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет,
// я влятеся ли первое число квадратом второго
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/
// Если в подчиненном блоке {одна строка}, то "{}" можно опустить или написать 
// полностью одной строкой.

//Task 2. Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.WriteLine("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current<= number)
{
    Console.Write(current + " "); // конкатенация! добавляет символ пробела, чтобы
                                  //между числами был промежуток
    current = current+1; //можно записать current++
}
*/

/*
//в данной ситуации мы отсекаем младшие разряды
32546 / 10 = 3254
32546 / 100 = 325
32546 / 1000 = 32
32546 / 10000 = 3

// "% - остаток"
а тут мы обращаемся(!!!) к младшим разрядам
32546 % 10 = 6
32546 % 100 = 46
32546 % 1000 = 546
32546 % 10000 = 2546

234635 -> 46 
234635 / 100 = 2346
2346 % 100 = 46
*/