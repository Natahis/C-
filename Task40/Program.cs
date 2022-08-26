// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.WriteLine("Введите три целых положительных числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

void Triangl(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > c) Console.WriteLine("Треугольник с такими сторонами существует.");
    else Console.WriteLine("Треугольника с такими сторонами не существует.");
}

Triangl(num1, num2, num3);