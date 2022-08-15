// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти системы координат: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1) Console.WriteLine("x > 0, y > 0");
// else if (number == 2) Console.WriteLine("x < 0, y > 0");
// else if (number == 3) Console.WriteLine("x < 0, y < 0");
// else if (number == 4) Console.WriteLine("x > 0, y < 0");
// else Console.WriteLine("Ваедены некоректные данные!")

string GIT (int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return "Ваедены некоректные данные!";
}

string result = GIT(number);
Console.WriteLine(result);