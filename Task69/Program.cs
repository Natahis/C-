// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите 2 целых положительных числа: ");
Console.Write("Число A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B = ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return a * Degree(a, b - 1);
}
int result = Degree(a,b);
Console.WriteLine(result);

