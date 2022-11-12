// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumberBack(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumberBack(num - 1);
}

Console.Write("Введите целое число N: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumberBack(number);