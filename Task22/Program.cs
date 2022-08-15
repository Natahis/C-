// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите любое целое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Неверное число!");
int i = 1;
while (i <= number)
{
    Console.WriteLine($"{i}    {i*i}");
    // Console.WriteLine(i*i);
    i++;
}

Console.WriteLine();
