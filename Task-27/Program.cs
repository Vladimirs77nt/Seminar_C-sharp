// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введиде число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum_dig = SumDigit(number);
Console.WriteLine($"{number} -> {sum_dig}");

int SumDigit(int num) // метод подсчета суммы цифр в числе
{
    if (num<0) num = -num; // если число отрицательное - то делаем его положительным
    int result = default;
    while (num>0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}