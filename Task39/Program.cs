// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника

int[] GreateArrayRndInt(int size, int min, int max)
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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

// void ReversArray1(int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;
//     while (index1 < index2)
//     {
//        int obj = array[index1];
//        array[index1] = array[index2];
//        array[index2] = obj;
//        index1++;
//        index2--; 
//     }
// }

void ReversArray2(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }

}

int[] arr = GreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReversArray2(arr);
PrintArray(arr);