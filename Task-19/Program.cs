// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
    if (number == Palinodrom(number))
        Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
else Console.WriteLine ("ошибка, введено неверное число");

int Palinodrom (int num)
    {                           // num = 12345
    int digit1 = num/10000;     // 1 = 1
    int digit2 = num/1000 % 10; // 12 % 10 = 2
    int digit3 = num/100 % 10;  // 123 % 10 = 3
    int digit4 = num/10 % 10;   // 1234 % 10 = 4
    int digit5 = num % 10;      // 12345 % 10 = 5
    int palinodrom = digit5*10000+digit4*1000+digit3*100+digit2*10+digit1;
    return palinodrom;
    }