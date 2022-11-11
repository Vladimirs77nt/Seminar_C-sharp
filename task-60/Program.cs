// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DArrayInt(int rows, int columns, int depth, int start)  // метод создания целочисленного 2D массива
{
    var matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = start;
                start++;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix) // метод печати 3D массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int row = 3;        // количество строк в матрице
int column = 3;     // количество столбцов в матрице
int depth = 3;        // количество глубины в матрице

int[,,] array3D = Create3DArrayInt(row,column,depth,10); // создание матрицы по заданным параметрам

System.Console.WriteLine();
Console.WriteLine("Заданный массив:");
Print3DMatrix (array3D);                               // печать матрицы
System.Console.WriteLine();
