// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
    {
    int digit5 = number % 10; // 12345 % 10 = 5
    int digit4 = number/10 % 10; // 1234 % 10 = 4
    int digit3 = number/100 % 10; // 123 % 10 = 3
    int digit2 = number/1000 % 10; // 12 % 10 = 2
    int digit1 = number/10000; // 1 = 1
    int palinodrom = digit5*10000+digit4*1000+digit3*100+digit2*10+digit1;
    if (number == palinodrom)
        Console.WriteLine($"{number} -> да");
    else Console.WriteLine("нет");
    }
else Console.WriteLine ("ошибка, введено неверное число!");