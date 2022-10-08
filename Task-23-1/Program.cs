// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// 
// ВНИМАНИЕ!!! Решение задачи сделано на основе решения от Дениса с прошедшего семинара №3
// Используем процедуру (функцию) !!!

void CubeTable(int num) // процедура вывода таблицы кубов от 1 до num
{
    int index = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,5} |{Math.Pow(index, 3),8} |");
        index++;
    }
}

Console.Write("Введите число (от 1 и более): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0) CubeTable(number);
else Console.WriteLine("ошибка");