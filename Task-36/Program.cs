// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void PrintArray(int[] array) // метод печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {       if (i<(array.Length - 1)) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SumNumberGetOddPositionArray(int[] array) // метод подсчета элементов на нечетных позициях массива
{
    int summ = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) summ += array[i];
    }
    return summ;
}

Console.Write("Введите размер массива: ");                // просим задать размер массива
int sizeArray = Convert.ToInt32(Console.ReadLine());      // принимаем на входе размер массива
int[] arr = CreateArrayRndInt(sizeArray, -10, 10);        // создаем массив
PrintArray(arr);                                          // печатаем массив в виде [3, 7, 23, 12]
int result = SumNumberGetOddPositionArray(arr);           // находим сумму чисел в массиве на нечетных позициях
Console.WriteLine($" -> {result}");                       // добавляем результат [3, 7, 23, 12] -> 19