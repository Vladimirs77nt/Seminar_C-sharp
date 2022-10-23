// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//    1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // метод создания целочисленного массива
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

void PrintMatrix(int[,] matrix) // метод печати целочисленного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < (matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j],3}, "); // печать с форматированием
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
}

int row = 5;        // количество строк в массиве
int column = 5;     // количество столбцов в массиве
int[,] array2D = CreateMatrixRndInt(row, column, 1, 99); // создание массива по заданным параметрам
PrintMatrix(array2D);                                // печать массива

Console.Write($"Введите номер строки массива (от 0 до {row - 1}): ");
int row1 = Convert.ToInt32(Console.ReadLine());                         // ввод номера строки
Console.Write($"Введите номер столбца массива (от 0 до {column - 1}): ");
int column1 = Convert.ToInt32(Console.ReadLine());                      // ввод номер столбца

if (row1 >= 0 && column1 >= 0) // проверка введенных жанных
{
    if (row1 < row && column1 < column) Console.WriteLine($"Значение ячейки ({row1}, {column1}) = {array2D[row1, column1]}");
    else Console.WriteLine("-> такого элемента в массиве нет");
}
else Console.WriteLine("-> ошибка! введено отрицательное число");