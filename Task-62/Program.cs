// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralArray(int row, int column, int start)  // метод создания 2D массива спиралью
{
    var matrix = new int[row, column];
    int size = row * column;
    int i = 0;
    int j = -1;
    int k = 1; // направление заполнения массива изначально - направо !!!
    int count = 0;
    while (count < size)
    {
        if (k == 1) // если двигаемся НАПРАВО
        {
            if (j < (column - 1)) // если НЕ достигли границы справа
            {
                if (matrix[i, j + 1] == 0) // если клетка справа пустая
                {
                    j++;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 2;
            }                 // если клетка справа НЕ пустая - то двигаемся вниз
            else k = 2;  // если ДОСТИГЛИ границы справа - то двигаемся вниз
        }

        if (k == 2) // если двигаемся ВНИЗ
        {
            if (i < (row - 1))  // если НЕ достигли границы снизу
            {
                if (matrix[i + 1, j] == 0)  // если клетка снизу пустая
                {
                    i++;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 3;  // если клетка снизу НЕ пустая - то двигаемся налево
            }
            else k = 3;     // если ДОСТИГЛИ границы снизу - то двигаемся налево
        }

        if (k == 3) // если двигаемся НАЛЕВО
        {
            if (j > 0)   // если НЕ достигли границы слева
            {
                if (matrix[i, j - 1] == 0)   // если клетка слева пустая
                {
                    j--;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 4;   // если клетка слева НЕ пустая - то двигаемся наверх
            }
            else k = 4;   // если ДОСТИГЛИ границы слева - то двигаемся наверх
        }

        if (k == 4) // если двигаемся НАВЕРХ
        {
            if (i > 0)   // если НЕ достигли границы сверху
            {
                if (matrix[i - 1, j] == 0)   // если клетка сверху пустая
                {
                    i--;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 1;    // если клетка сверху НЕ пустая - то двигаемся направо
            }
            else k = 1;  // если ДОСТИГЛИ границы снизу - то двигаемся направо
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // метод печати 2D массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < (matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j]:d2}  "); // печать с форматированием
            else Console.Write($"{matrix[i, j]:d2}");
        }
        Console.WriteLine(" |");
    }
}

int row = 8;        // количество строк в матрице
int column = 8;     // количество столбцов в матрице
int[,] array2D = CreateSpiralArray(row,column,1); // создание спиральной матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Спиральный массив:");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();