// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] arr2D = GreateMatrixRndInt(3, 3, -99, 99);
PrintMatrix(arr2D);
Console.WriteLine();


void ReplecmentString(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i > j)
            {
                 int temp = matrix[i,j];
                 matrix[i, j] = matrix[j,i];
                 matrix[j,i] = temp;
            }   
        }
    }
}
if (arr2D.GetLength(0) == arr2D.GetLength(1))
{
     ReplecmentString(arr2D);
     PrintMatrix(arr2D);
}   
else Console.WriteLine("Задачу решить невозможно. Число строк должно быть равно числу столбцов."); 
