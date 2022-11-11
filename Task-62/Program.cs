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
        if (k == 1) // если двигаемся направо;
        {
            if (j < (column - 1))
            {
                if (matrix[i, j + 1] == 0) // если НЕ достигли границы справа и клетка справа пустая;
                {
                    j++;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 2;
            }                 // если клетка справа НЕ пустая или ДОСТИГЛИ границы справа - то двигаемся вниз;
            else k = 2;
        }

        if (k == 2) // если двигаемся вниз
        {
            if (i < (row - 1))  // если клетка снизу пустая и НЕ достигли границы снизу;
            {
                if (matrix[i + 1, j] == 0)  // если клетка снизу пустая и НЕ достигли границы снизу;
                {
                    i++;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 3;                   // если клетка снизу НЕ пустая или ДОСТИГЛИ границы снизу - то двигаемся налево;
            }
            else k = 3;
        }

        if (k == 3) // если двигаемся налево
        {
            if (j > 0)   // если НЕ достигли границы слева и клетка слева пустая;
            {
                if (matrix[i, j - 1] == 0)   // если НЕ достигли границы слева и клетка слева пустая;
                {
                    j--;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 4;                   // если клетка слева НЕ пустая или ДОСТИГЛИ границы слева - то двигаемся наверх;
            }
            else k = 4;
        }

        if (k == 4) // если двигаемся наверх
        {
            if (i > 0 && matrix[i - 1, j] == 0)   // если НЕ достигли границы сверху или клетка сверху пустая;
            {
                if (i > 0 && matrix[i - 1, j] == 0)   // если НЕ достигли границы сверху или клетка сверху пустая;
                {
                    i--;
                    matrix[i,j] = start;
                    start++;
                    count++;
                }
                else k = 1;                   // если клетка сверху НЕ пустая или ДОСТИГЛИ границы снизу - то двигаемся направо;
            }
            else k = 1;
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

int row = 4;        // количество строк в матрице
int column = 4;     // количество столбцов в матрице
int[,] array2D = CreateSpiralArray(row,column,1); // создание спиральной матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Спиральный массив:");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();