// Заплолнение массива вещественными числами.

double[,] GreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rand = rnd.NextDouble()* (max - min) + min;
            matrix[i, j] = Math.Round(rand, 2); // Округление до 2 знаков.
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            // else Console.Write($"{matrix[i, j], 4}");
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],6};" : $"{matrix[i, j],6}");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = GreateMatrixRndDouble(3, 4, 10, 40);
PrintMatrix(array2D);