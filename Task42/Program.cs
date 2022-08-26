// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое пложительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// int mult=1;

// while (num > 0)
// {
//     result = result + num % 2 * mult;
//     num = num / 2;
//     mult = mult * 10;
// }
// Console.WriteLine(result);

void DecToBin(int number)
{
    if (number == 0) return;
    DecToBin(number / 2);
    Console.Write(number % 2);
}
DecToBin(num);