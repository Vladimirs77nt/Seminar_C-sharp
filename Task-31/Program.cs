// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

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

int[] GetSumPositiveNegative(int[] array)
{
    int sumPositive = default;
    int sumNegative = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    return new int[] {sumNegative, sumPositive};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray (arr);

int[] result = GetSumPositiveNegative(arr);
Console.WriteLine($"Сумма положительных чисел = {result[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {-result[0]}");





// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     var array = new int[size];
// void PrintArray (int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }
// int[] GetSumPositiveNegativElem (int[] array)
// {
//     int sumNegative = default;
//     int sumPositive = default;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0) sumNegative += array[i];
//         else sumPositive += array[i];
//     }

//     return new int[] {sumNegative, sumPositive};
// }
// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// int[] result = GetSumPositiveNegativElem(arr);

// Console.WriteLine($"Сумма положительных чисел = {result[1]}");
// Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");
