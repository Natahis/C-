// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] GreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            // else Console.Write($"{matrix[i, j], 4}");
            Console.Write(j < matrix.GetLength(1) - 1?$"{matrix[i, j], 4},":$"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] arr2D = GreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(arr2D);
Console.WriteLine();

int[] GreateArray(int[,] matrix)
{
     int size = matrix.GetLength(0)*arr2D.GetLength(1);
     int[] array = new int[size];
     int k = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {   
             array[k] = matrix[i,j];
             k++;      
         }
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

int[] arr = GreateArray(arr2D);
PrintArray(arr);

Array.Sort(arr);
PrintArray(arr);

void Result(int[] array)
{
int count = 0;
int num = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num) 
    {
        num = array[i];
        count++;
    }
    else 
    {
        Console.WriteLine($"Значение  {num}  встречается {count} раз.");
        num = array[i];
        count = 1;
    }
}
Console.WriteLine($"Значение  {num}  встречается {count} раз.");
}
Result(arr);