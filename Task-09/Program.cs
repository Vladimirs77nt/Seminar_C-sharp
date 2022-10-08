// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
// int number = 55;

Console.WriteLine($"Случайное число из диапозона 10 - 99 = {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit)
//     Console.WriteLine ("Цифры одинаковые!");
// else if (firstDigit > secondDigit)
//     Console.WriteLine ($"Наибольшая цифра числа = {firstDigit}");
// else
//     Console.WriteLine ($"Наибольшая цифра числа = {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8

    // int result = default;

    //  if (firstDigit > secondDigit) result = firstDigit;
    //  else result = secondDigit;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");
