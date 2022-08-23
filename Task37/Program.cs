// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = new Random().Next(4, 9);

int[] GreateArray(int min, int max)
{
    int[] array = new int[size];
    // Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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



int[] Comp(int[] array)
{
    int size1 = 0;
    if (array.Length % 2 == 0) size1 = array.Length / 2;
    else size1 = (array.Length / 2) + 1;
    int[] comp = new int[size1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        comp[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) comp[size1 - 1] = array[array.Length / 2];

    return comp;
}

int[] arr = GreateArray(1, 9);
PrintArray(arr);
int[] result = Comp(arr);
Console.Write(" -> ");
PrintArray(result);










