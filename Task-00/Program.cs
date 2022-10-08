// Напишите программу, которая
// 1. на вход принимает число и
// 2. выдает его квадрат (число умноеженное на само себя)

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");