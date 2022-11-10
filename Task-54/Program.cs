// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// метод создания целочисленного 2D массива (матрицы)
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

// метод печати 2D массива (матрицы)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {       
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (j<(matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j], 3}, ");
        else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine(" ]");
    }
}

// метод пузырьковой сортировки каждой строки массива
void SortMatrix(int[,] matrix)
{
    int size = matrix.GetLength(1);
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j1 = 0; j1 < size-1; j1++)
        {
            for (int j2 = 0; j2 < size - 1 - j1; j2++)
            {
                if (matrix[i,j2] < matrix[i,j2+1])
                {
                    temp = matrix[i,j2];
                    matrix[i,j2] = matrix[i,j2+1];
                    matrix[i,j2+1] = temp;
                }
            }
        }
    }
}

int row = 5;        // задаем количество строк в матрице
int column = 5;     // задаем количество столбцов в матрице
int[,] array2D = CreateMatrixRndInt(row,column,0,19); // создание матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Созданная исходная матрица (random):");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();

SortMatrix(array2D);                                 // сортировка строк матрицы по убыванию
Console.WriteLine("Отсортированная матрица:");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();