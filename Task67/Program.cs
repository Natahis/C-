// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

int NaturalNumber(int num)
{
    int sum = num % 10;

    if (num == 0) return sum;
    
    return sum = sum + NaturalNumber(num / 10);;
    
}   

int result = NaturalNumber(num);
Console.WriteLine(result);
