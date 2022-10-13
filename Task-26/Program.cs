// Задача 26. Напишите программу, которая
// принимает на вход число и выдает кол-во
// цифр в числе.

Console.Write("Введиде число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = SizeDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {size}");

int SizeDigit (int num)
{
    int sizeDigit = 1;
    while (num>9)
    {
        sizeDigit++;
        num /= 10;
    }
    return sizeDigit;
}