// Задача 24. Напишите программу, которая
// принимает на вход число (А) и выдает
// сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SummA(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");

int SummA (int a)
{
    int SummA = 0;
    for (int i = 1; i < a+1; i++)
    {
        SummA = SummA + i;
    }
    return SummA;
}