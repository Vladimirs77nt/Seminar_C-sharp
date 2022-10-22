// Задача 51. Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные
// и замените эти элементы их квадратами.

//  m = 3, n = 4        результат
// 1 4 7 2              1   4 49  2
// 5 9 2 3              5   9  2  3
// 8 4 2 4              64  4  4  4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rnd.Next(min, max+1); 
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

int SummPrimeDiagonaleMatrix(int[,] matrix)
{
    int summ = 0;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(1)<matrix.GetLength(0)) size = matrix.GetLength(1);
    for (int i = 0; i < size; i++)
        {
        summ = summ + matrix[i, i]; 
        }
    return summ;
}

int[,] array2D = CreateMatrixRndInt(4,3,1,9);
PrintMatrix (array2D);
Console.WriteLine();
int res = SummPrimeDiagonaleMatrix(array2D);
Console.WriteLine(res);