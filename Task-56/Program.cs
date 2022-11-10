// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 1 4 7 2  / = 14
// 5 9 2 3  / = 19
// 8 4 2 4  / = 18
// 5 2 6 7  / = 20
// 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// метод подсчета суммы указанной строки 2D массива (матрицы)
int SummRowMatrix(int[,] matrix, int i)
{
    int summ = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summ = summ + matrix[i,j];
    }
    return summ;
}

// метод поиска строки 2D массива (матрицы) с наименьшей суммой
int SearchSummRowMin(int[,] matrix)
{
    int rowminimum = 0;
    int rowsummminimum = SummRowMatrix(matrix, 0);
    int rowsumm;
    // Console.WriteLine($"Сумма строки 0 = {rowsummminimum}");
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        rowsumm = SummRowMatrix(matrix, i);
        // Console.WriteLine($"Сумма строки {i} = {rowsumm}");
        if (rowsumm < rowsummminimum)
        {
            rowsummminimum = rowsumm;
            rowminimum = i;
        }
    }
    return rowminimum;
}

int row = 4;        // задаем количество строк в матрице
int column = 4;     // задаем количество столбцов в матрице
int[,] array2D = CreateMatrixRndInt(row,column,0,9); // создание матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Созданная исходная матрица (random):");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();

int rowmin = SearchSummRowMin (array2D);             // поиск строки массива с ниаменьшей суммой
Console.WriteLine($"Строка массива с наименьшей суммой: {rowmin}");
System.Console.WriteLine();