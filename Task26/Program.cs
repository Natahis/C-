// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
if (num < 0) num = num * -1;
// while (num % 10 > 0)
// {
//     num = num / 10;
//     i++;
// }
// Console.WriteLine($"Введеное число состоит из {i} цифр.");

// int j = 0;
// for (int i = 0; num > 0; i++)
// {
//     num = num / 10;
//     j = i + 1;
// }
// Console.WriteLine($"Введеное число состоит из {j} цифр.");

int i = 0;
int Count(int number)
{
while (number > 0)
    {
        number = number / 10;
        i++;
    }
return i;
}

int result = Count(num);
Console.WriteLine($"Введеное число состоит из {result} цифр.");



 