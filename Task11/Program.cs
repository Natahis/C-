// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
int ferst = number / 100;
int third = number % 10;
int result = ferst * 10 + third;

Console.WriteLine($"{number} -> {result}");
