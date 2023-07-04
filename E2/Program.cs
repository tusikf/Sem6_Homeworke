// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Даны два уравнения:");
Console.WriteLine(" y = k1 * x + b1   и     y = k2 * x + b2");

Console.Write("Введите коэффициент k1 : ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент k2 : ");
double k2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b1 : ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите коэффициент b2 : ");
double b2 = int.Parse(Console.ReadLine()!);

double r = k1 - k2;
if ( r == 0) 
{
    Console.WriteLine("Прямые не пересекаются!");
}
else 
{
    double x = getSchitaemX( k1, k2, b1, b2 );
    double y = getSchitaemY( k1, b1, x);
    Console.WriteLine($"Прямые пересекаются в точке с координатами : ( {x} ; {y})");
}

// Метод для вычисления координаты х
double getSchitaemX( double arg1, double arg2, double koef1, double koef2)
{
    double result = (koef2-koef1)/(arg1-arg2);
    return result;
}

// Метод для вычисления координаты y
double getSchitaemY( double k, double b , double xx)
{
    double result2 = k*xx+b;
    return result2;
}