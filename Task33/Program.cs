// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int size = new Random().Next(4, 9);
Console.WriteLine($"Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] GreateArray(int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]},");
        else if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}]");
    }
}

// void FindNumber(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             Console.Write($"-> Да ");
//             break;
//         }
//         Console.Write($" -> Нет");
//         break;
//         }
//     }
// }

bool FindNumber(int[] array, int num)
{
    bool j = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            j = true;
            break;
        }
    }
    return j;
}

int[] arr = GreateArray(0, 10);
PrintArray(arr);
bool result = FindNumber(arr, number);
Console.Write(result ? "-> Да" : "-> Нет");