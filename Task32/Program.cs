// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = new Random().Next(4,10);
// int[] array1 = new int[size];
// int[] array = new int[size];

void PrintArray(int[]array)
{
    for (int i = 0; i < size; i++)
    {
         if (i == 0) Console.Write($"[{array[i]},");
         else if (i < size-1) Console.Write($"{array[i]},");
         else Console.Write($"{array[i]}]");
    }     
}

int[] GreateArray(int size, int min, int max)
{
    
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}

void ChahgArray(int[] array)
{
     for (int i = 0; i < size; i++)
     {
         array[i] = array[i] * -1;
     }
}

int[] arr = GreateArray(size, -9, 10);
PrintArray(arr);
ChahgArray(arr);
Console.Write(" -> ");
PrintArray(arr);




