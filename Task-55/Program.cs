 // Задача 55. Задайте двумерный массив чисел. Напишите программу, которая заменяет строки на столбцы.
 // В случае, если это невозможно, программа должна вывести сообщение пользователю.

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

void ChangeMatrixRowColumn(int[,] matrix) // метод замены строк на столбцы

{
    int temp;
    int lenght = matrix.GetLength(0);
    for (int i = 0; i < lenght-1; i++)
    {   
        for (int j = i+1; j < lenght; j++)
        {
            temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }
    }
}

int row = 8;        // количество строк в массиве
int column = 8;     // количество столбцов в массиве
if (row == column)
    {
    int[,] array2D = CreateMatrixRndInt(row,column,1,99); // создание массива по заданным параметрам
    PrintMatrix (array2D);                                // печать массива
    System.Console.WriteLine();
    ChangeMatrixRowColumn (array2D);                   // делаем замену в массиве - строки на столбцы
    PrintMatrix (array2D);                                // печать массива
    }
else Console.WriteLine("Кол-во строк и столбцов в заданном массиве - не равны!");