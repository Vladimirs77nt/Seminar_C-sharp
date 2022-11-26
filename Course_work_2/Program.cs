// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
// массивами.

// Вариант 2 - с использованием методов

string[] CrateStringArray(int size) // метод №1 - консольный ввод массива строк
{
    var Array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"введите строку {i + 1}: ");
        Array[i] = Console.ReadLine();
    }
    return Array;
}

int LengthStringBeforeX(string[] Array, int x) // метод №2 - подсчет кол-ва элементов с длиной строки меньше или равно x
{
    int length = 0;
    for (int i = 0; i < Array.Length; i++)
        if (Array[i].Length <= x) length++;
    return length;
}

string[] CrateArray2(string[] Array, int x) // метод №3 - создание нового массива по условиям задачи
{
    int sizeArray2 = LengthStringBeforeX(Array, x); // вызов метода LenghtStringBeforeX
    var Array2 = new string[sizeArray2];
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= x)
        {
            Array2[count] = Array[i];
            count++;
        }
    }
    return Array2;
}

void PrintArray(string[] Array) // метод №4 - печать массива через запятую
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write(Array[i]);
        Console.Write(", ");
    }
    Console.WriteLine(Array[Array.Length - 1]);
}

Console.WriteLine("Требуется ввести некоторое кол-во строк различной длины.");
Console.WriteLine("Сначала введите кол-во вводимых строк:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray > 0)
{
    Console.WriteLine("Начните вводить строки, завершая их нажатием клавиши Enter");
    string[] StringArray = CrateStringArray(sizeArray); // консольный ввод строк
    int sizeArray2 = LengthStringBeforeX(StringArray, 3);
    if (sizeArray2 > 0)
    {
        Console.Write("Результат: ");
        PrintArray(CrateArray2(StringArray, 3));
    }
    else Console.WriteLine("В введенных данных нет строк удовлетворяющих условиям задачи");
}
else Console.WriteLine("Строки не введены");