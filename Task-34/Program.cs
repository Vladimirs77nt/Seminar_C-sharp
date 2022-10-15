// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt3(int size) // метод создания массива заполненный случайными положительными трёхзначными числами
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);  // заполняются только трехзначные числа !!!
    }
    return array;
}

void PrintArray(int[] array) // метод печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {   if (i<(array.Length - 1)) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EvenNumbersArray(int[] array) // метод подсчета четных чисел массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");                // просим задать размер массива
int sizeArray = Convert.ToInt32(Console.ReadLine());      // принимаем на входе размер массива
int[] arr = CreateArrayRndInt3(sizeArray);                // создаем массив
PrintArray(arr);                                          // печатаем массив в виде [345, 897, 568, 234]
int result = EvenNumbersArray(arr);                       // находим кол-во четных чисел в массиве
Console.WriteLine($" -> {result}");                       // добавляем результат [345, 897, 568, 234] -> 2