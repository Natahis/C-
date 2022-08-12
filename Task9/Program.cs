// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int number = new Random().Next(10, 100); // на 1 больше чем последнее число диапазонасщтс
//Console.WriteLine($"Случайное число из отрезка [1,99] = {number}");
// int ferst = number / 10;
// int second = number % 10;
// if (ferst == second) Console.WriteLine($"Цифры в числе {number} равны");
// // else if (ferst > second) Console.WriteLine($"Наибольшая цифра числа {number} = {ferst}");
// // else Console.WriteLine($"Наибольшая цифра числа {number} = {second}");
// int resalt = ferst > second ? ferst : second;
// Console.WriteLine($"Наибольшая цифра числа {number} = {resalt}");

int Max(int num)
{
    int ferst = num / 10;
    int second = num % 10;
    if (ferst == second) return 0;
    int resalt = ferst > second ? ferst : second;
    return resalt;
}

int resalt = Max(number);
string res = resalt == 0 ? "Цифры в числе равны" : resalt.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} = {res}"); 