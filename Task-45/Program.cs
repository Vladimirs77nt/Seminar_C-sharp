// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max) // метод создания массива заполненного случайными числами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array) // метод печати 1D массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {       if (i<(array.Length - 1)) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void PrintArray2D(int[] array) // метод печати 2D массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {       if (i<(array.Length - 1)) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] CopyMassive(int[] array) // метод копирования массива
{
    int size = array.Length;
    int[] arraycopy = new int[size];
    for (int i = 0; i < size; i++)
    {
        arraycopy[i] = array[i];
    }
    return arraycopy;
}

int[] arr = CreateArrayRndInt(10, 0, 25);        // создаем массив
PrintArray2D(arr);                                 // печатаем массив
Console.WriteLine();
PrintArray(CopyMassive(arr));                    // печатаем копию массива