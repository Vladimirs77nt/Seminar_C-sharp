﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {       if (i<(array.Length - 1)) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SearchNum2(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(10, 0, 200);
PrintArray (arr);

int result = SearchNum2(arr);
Console.WriteLine($"Количество чисел в диапозоне от 10 до 99 = {result}");
