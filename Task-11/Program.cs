// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из диапозона 10 - 999 = {number}");

int NumberPrint(int num)
{
    int firstDigit = num / 100; // 781 / 100 = 7 первая цифра
    int thirdDigit = num % 10; // 781 % 10 = 1 третья цифра

    return firstDigit * 10 + thirdDigit;
}

int result = NumberPrint (number);
Console.WriteLine ($"{number} -> {result}");