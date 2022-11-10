 // Задача 53. Задайте двумерный массив чисел.
 // Напишите программу, которая поменяет местами первую и последнюю строки массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // метод создания целочисленного 2D массива
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

void PrintMatrix(int[,] matrix) // метод печати целочисленного 2D массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {       
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (j<(matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j], 3}, "); // печать с форматированием
        else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine(" ]");
    }
}

void ChangeMatrixFirstLastRow(int[,] matrix) // метод замены местами первой и последней строки массива.

{
    int temp;
    int lastrow = matrix.GetLength(0)-1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {       
        temp = matrix[0,j];
        matrix[0,j] = matrix[lastrow,j];
        matrix[lastrow,j] = temp;
    }
}

int row = 3;        // количество строк в массиве
int column = 4;     // количество столбцов в массиве
int[,] array2D = CreateMatrixRndInt(row,column,1,99); // создание массива по заданным параметрам
PrintMatrix (array2D);                                // печать массива
System.Console.WriteLine();
ChangeMatrixFirstLastRow (array2D);                   // делаем замену строк в массиве
PrintMatrix (array2D);                                // печать массива
