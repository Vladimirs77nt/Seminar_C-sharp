// Задача 59. Задайте двумерный массив из целыъ чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

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

void PrintMatrix(int[,] matrix) // метод печати 2D массива
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

int[,] CreateMatrixDelete(int[,] matrix, int[] arrayMinElement)  // метод создания матрицы с удалением строки и столбца
{
    int[,] newmatrix = new int [(matrix.GetLength(0)-1), (matrix.GetLength(1)-1)];
    int iold = 0;
    int jold = 0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        if (iold == arrayMinElement[0]) iold++;
        jold = 0;
        for (int j = 0; j < newmatrix.GetLength(0); j++)
        {
            if (jold == arrayMinElement[1]) jold++;
            newmatrix[i,j] = matrix[iold, jold];
            jold++;
        }
        iold++;
    }
    return newmatrix;
}

int[] SearchPosMinElement(int[,] matrix) // метод поиска позиции наименьшего элемента в матрице
{
    int [] minposition = new int [3];
    minposition [0] = 0;
    minposition [1] = 0;
    minposition [2] = matrix[0,0];
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        if (matrix[i,j] <= minposition [2])
        {
            minposition [2] = matrix[i,j];
            minposition [0] = i;
            minposition [1] = j;
        }
    }
   return minposition;
}

int row = 4;        // количество строк в матрице
int column = 4;     // количество столбцов в матрице
int[,] array2D = CreateMatrixRndInt(row,column,0,9); // создание матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Заданный массив:");
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();

int[] minpos = SearchPosMinElement(array2D);         // поиска позиции минимального элемента

System.Console.WriteLine($"Минимальный элемент в таблице = {minpos[2]}");
System.Console.WriteLine($"Его коордианты: {minpos[0]} {minpos[1]}");
System.Console.WriteLine();

int[,] newarray2D = CreateMatrixDelete(array2D,minpos); // создание новой матрицы
Console.WriteLine("Измененный массив:");
PrintMatrix (newarray2D);                                  // печать матрицы
System.Console.WriteLine();
