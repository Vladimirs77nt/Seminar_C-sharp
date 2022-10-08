void SquareTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица квадратов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,4}|{Math.Pow(index, 2),4}|");
        index++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareTable(number);

// решение от Дениса