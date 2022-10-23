// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // метод создания целочисленного массива
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

double[] ArithmeticMeanColumn(int[,] matrix) // метод подсчета среднеарифметического каждого столбца
{                                            // результат заносится в одномерный массив   
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++) // счетчик по столбцам
    {
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) // счетчик по строчкам
        {
            summ += Convert.ToDouble(matrix[i, j]);
        }
        result[j] = Math.Round((summ / matrix.GetLength(0)), 1);
    }
    return result;
}

void PrintArray(double[] array) // метод печати среднеарифметического
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    Console.Write("> ");
    for (int i = 0; i < array.Length; i++) // счетчик по столбцам
    {
        if (i < array.Length - 1) Console.Write($"{array[i],3}, ");
        else Console.WriteLine($"{array[i],3}");
    }
}

int row = 4;                                             // количество строк в массиве
int column = 6;                                          // количество столбцов в массиве
int[,] array2D = CreateMatrixRndInt(row, column, 1, 10); // создание массива по заданным параметрам
PrintMatrix(array2D);                                    // печать массива
double[] arithmetic = ArithmeticMeanColumn(array2D);     // вызов метода подсчета среднефриметического
PrintArray(arithmetic);                                  // печать результата