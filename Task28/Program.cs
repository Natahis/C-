// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = 1;
if (number > 1) 
{
    // for (int i = 1; i <= number; i++)
    // {
    //     product = product * i;
    // }
    int result = Product(number);
    Console.Write($"Произведение чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine("Некорректный ввод! ");
}

int Product(int num)
{
    for (int i = 1; i <= num; i++)
    {
        product = product * i;
    }
    return product;
}