// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// метод создания целочисленного 2D массива (матрицы)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// метод печати 2D массива (матрицы)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < (matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
}

// метод произведения двух матриц
int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    int m = matrix1.GetLength(0); // кол-во строк в матрице 1 
    int n = matrix1.GetLength(1); // кол-во столбцов в матрице 1 и строк в матрице 2
    int k = matrix2.GetLength(1); // кол-во столбцов в матрице 2
    int[,] matrix3 = new int[m, k];
    int element;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            element = 0;
            for (int x = 0; x < n; x++)
            {
                element = element + matrix1[i, x] * matrix2[x, j];
            }
            matrix3[i, j] = element;
        }
    }
    return matrix3;
}

int row1 = 4;        // задаем количество строк в матрице 1
int column1 = 3;     // задаем количество столбцов в матрице 1
int[,] array1 = CreateMatrixRndInt(row1, column1, 0, 9); // создание матрицы 1 по заданным параметрам

int row2 = 3;        // задаем количество строк в матрице 2
int column2 = 2;     // задаем количество столбцов в матрице 2
int[,] array2 = CreateMatrixRndInt(row2, column2, 0, 9); // создание матрицы 2 по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Созданная исходная матрица 1 (random):");
PrintMatrix(array1);                               // печать матрицы 1
System.Console.WriteLine();
Console.WriteLine("Созданная исходная матрица 2 (random):");
PrintMatrix(array2);                               // печать матрицы 2
System.Console.WriteLine();

if (column1 == row2)
{
    int[,] array3 = CompositionMatrix(array1, array2);  // произведение двух матриц
    Console.WriteLine("Результат произведения двух матриц:");
    PrintMatrix(array3);                                // печать матрицы 3
    System.Console.WriteLine();
}
else
{
    Console.WriteLine("Данные две матрицы нельзя перемножить!..");
    Console.WriteLine("Количество столбцов в матрице 1 не совпадает с количеством строк в матрице 2");
}