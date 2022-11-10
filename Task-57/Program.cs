// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словать содержит информацию о том, сколько раз встречается
// элемент входных данных

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
    Console.WriteLine("Заданный массив:");
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

void PrintDistionary(int[,] array) // метод печати словаря
{
    Console.WriteLine("Частотный массив:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[1,i] == 0) break;
        Console.Write("|");
        Console.Write($"{array[0,i], 2} встречается ");
        Console.Write($"{array[1,i], 3} раз(а)");
        Console.WriteLine(" |");
    }
}

int[] TransformMatrix2Dto1D(int[,] matrix2D)  // метод перевода 2D матрицы в простой массив
{
    int[] array = new int [matrix2D.GetLength(0) * matrix2D.GetLength(1)];
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
        array[i*(matrix2D.GetLength(1))+j] = matrix2D[i, j]; 
        }
    }
    return array;
}

int[,] FrequencyDictionary(int[] matrix) // метод создания частотного словаря
{
    int length = matrix.Length;
    int[,] matrixdictionary = new int [2,length];
    int num = matrix[0];
    int position = 0;
    matrixdictionary[0,0] = num;
    matrixdictionary[1,0] = 1;
    for (int i = 1; i < length; i++)
    {
        if (matrix[i] == num)
        {
            matrixdictionary[1,position]++;
        }
        else
        {
            position++;
            num = matrix[i];
            matrixdictionary[0,position] = num;
            matrixdictionary[1,position] = 1;
        }
    }
   return matrixdictionary;
}

int row = 5;        // количество строк в матрице
int column = 6;     // количество столбцов в матрице
int[,] array2D = CreateMatrixRndInt(row,column,1,9); // создание матрицы по заданным параметрам
PrintMatrix (array2D);                               // печать матрицы
System.Console.WriteLine();

int[] arr = TransformMatrix2Dto1D(array2D);   // создание простого массива из матрицы
Array.Sort(arr);                              // сортировка массива

int[,] distionary = FrequencyDictionary(arr);  // созадние СЛОВАРЯ
PrintDistionary (distionary);                  // печать СЛОВАРЯ