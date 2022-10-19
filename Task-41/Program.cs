// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputNumber(int num)         // метод консольного ввода чисел от пользователя по заданному кол-ву
{
    int[] array = new int[num];    // создаем массив заданного размера
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;  // возвращаемый массив чисел
}

int SummInputPositiveNumber(int[] array) // метод подсчета чисел больше 0 из входящего массива
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) summ++;
    }
    return summ;  // возвращаемое значение
}

Console.Write("Сколько чисел будет введено: ");
int number = Convert.ToInt32(Console.ReadLine());    // принимаем сколько чисел будет введено пользователем
int[] arr = InputNumber(number);                     // запускаем метод ввода чисел
int res = SummInputPositiveNumber(arr);              // запускаем метод подсчета кол-ва чисел больше 0
Console.Write($"Введено чисел более 0: {res}");      // печатаем результат