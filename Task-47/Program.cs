﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // метод заполнения массива вещественными числами
{
    var matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1); // !!! округление до 1 знака после запятой
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix) // метод печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < (matrix.GetLength(1) - 1)) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ]");
    }
}

double[,] array2D = CreateMatrixRndInt(6, 4, -100, 100);  // создание двухмерного массива размером 6х4 числами от -100 до 100
PrintMatrix(array2D);                                     // печать массива