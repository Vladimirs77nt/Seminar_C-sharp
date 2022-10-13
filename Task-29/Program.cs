// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num) // метод заполнения массива размером (num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100); // заполнение случайными числами от 0 до 99
    }
    return array;
}

void PrintArray (int[] arr) // процедура вывода массива (arr) на экран
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length-1]);
    Console.Write("]");
}

int[] myArray = FillArray (8);   // вызываем создание массива на 8 элементов
PrintArray (myArray);            // выводим его на экран