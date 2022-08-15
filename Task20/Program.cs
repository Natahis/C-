// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt((x2-x1)*(x2-x1)+(y1-y2)*(y1-y2));
// Console.WriteLine("Растояние между двумя точками = {0: #.##}", result);

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    // double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2));
    // return result;
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2));
}

double result = Distance(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));



