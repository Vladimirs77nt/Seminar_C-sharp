// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
// массивами.

// Вариант 1 - без использования методов

// 1 часть - консольный ввод данных (создание первого массива)
Console.WriteLine("Требуется ввести некоторое кол-во строк различной длины.");
Console.WriteLine("Сначала введите кол-во вводимых строк:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

if (sizeArray > 0)  // проверка условия необходимости дальнейшего решения задачи
{
    Console.WriteLine("Начните вводить строки, завершая их нажатием клавиши Enter");
    var StringArray = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write($"введите строку {i + 1}: ");
        StringArray[i] = Console.ReadLine();
    }

    // 2 часть - вычисление: сколько введенных строк удовлетворяют условию задачи
    int sizeArray2 = 0;
    for (int i = 0; i < sizeArray; i++)
    {
        if (StringArray[i].Length <= 3) sizeArray2++;
    }

    if (sizeArray2 > 0)         // проверка условия необходимости дальнейшего решения задачи
    {
        // 3 часть - создание второго массива со строками удовлетворяющими условиям задачи
        int count = 0;
        var StringArray2 = new string[sizeArray2];     // создаем второй массив
        for (int i = 0; i < sizeArray; i++)
        {
            if (StringArray[i].Length <= 3)
            {
                StringArray2[count] = StringArray[i];
                count++;
            }
        }

        // 4 часть - вывод результата
        Console.Write("Результат: ");
        for (int i = 0; i < sizeArray2 - 1; i++)
        {
            Console.Write(StringArray2[i]);
            Console.Write(", ");
        }
        Console.WriteLine(StringArray2[sizeArray2 - 1]);
    }
    else Console.WriteLine("В введенных данных нет строк удовлетворяющих условиям задачи");
}
else Console.WriteLine("Строки не введены");