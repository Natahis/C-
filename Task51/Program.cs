// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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
            Console.Write(j < matrix.GetLength(1) - 1?$"{matrix[i, j], 3},":$"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

int MatrixSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum = sum + matrix[i,j];
        }
    }
    return sum;
}
int[,] arr2D = GreateMatrixRndInt(5, 4, 0, 9);
PrintMatrix(arr2D);
int result = MatrixSum(arr2D);
Console.WriteLine($"Сумма элементов главной диагонали -> {result}");