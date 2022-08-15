// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Ввендите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверь");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверь");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверь");
// else Console.WriteLine("Ваедены некоректные данные");

string GetQuarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверь";
    if (xc < 0 && yc < 0) return "Третья четверь";
    if (xc > 0 && yc < 0) return "Четвертая четверь";
    return "Ваедены некоректные данные";
} 

string result = GetQuarter(x, y);
Console.Write(result);