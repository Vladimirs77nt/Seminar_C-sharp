// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummNatural(int num1, int num2) // принимаем что num2 больше или равно num1
{
    if (num2 == num1 - 1) return 0;
    return num2 + SummNatural(num1, num2 - 1);
}

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int res;

if (number2 > number1) res = SummNatural(number1, number2);
else res = SummNatural(number2, number1);
Console.WriteLine($"Сумма натуральных элементов в промежутке: {res}");