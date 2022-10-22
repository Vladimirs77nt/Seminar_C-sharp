// Задача 48. Задайте двумерный массив размера m на n,
// каждый элмент массива находится по формуле: Amn = m + n
// Выведите полученный результат на экран.
//  m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrix(int rows, int columns)
{
    var matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // метод печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {       
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (j<(matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] array2D = CreateMatrix (3,4);
PrintMatrix (array2D);