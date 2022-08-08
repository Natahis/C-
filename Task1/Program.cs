// Определить является ли число квадратом другого
Console.WriteLine("Введите два целых числа:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if (A == B * B)
{
    Console.Write($"Да, число {A} является квадратом числа {B}");
}
else
{
    Console.Write($"Нет, число {A} не является квадратом числа {B}");
}