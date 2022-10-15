// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)  // метод создания массива заполненного случайными ВЕЩЕСТВЕННЫМИ числами !!!
{
    var array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
    }
    return array;
}

void PrintArrayDouble(double[] array) // метод печати массива с вешественными числами !!!
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double MaxArray(double[] array) // метод поиска МАКСИМАЛЬНОГО значения в массиве
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinArray(double[] array) // метод поиска МИНИМАЛЬНОГО значения в массиве
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Введите размер массива (более 1 элемента): ");  // просим задать размер массива
int sizeArray = Convert.ToInt32(Console.ReadLine());      // принимаем на входе размер массива
if (sizeArray>1)                                          // проверка массива - чтобы бы был не менее 2 элементов
{
double[] arr = CreateArrayRndDouble(sizeArray, -10, 10);  // создаем массив
PrintArrayDouble(arr);                                    // печатаем массив в виде [3.5, 7.1, 22.9, 2.3, 78.5]
double result = MaxArray(arr) - MinArray(arr);            // находим разницу между максимальным и минимальным элементов массива
result = Math.Round(result, 2);                           // пришлось ввести округление, т.к. иначе в некоторых случаях выдает много цифр после запятой
Console.WriteLine($" -> {result}");                       // добавляем результат [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
}
else Console.WriteLine("Ошибка ввода"); // обработка ошибки ввода