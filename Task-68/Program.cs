// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

long Akkerman(long m, long n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Программа вычисления функции Аккермана вида A(m,n) с помощью рекурсии");
Console.WriteLine("Внимание! Числа должны быть неотрицательными!");
Console.Write("Введите первое целое число (m): ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число (n): ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN >= 0 && numberM >= 0)
{
    long res = Akkerman(numberM, numberN);
    Console.WriteLine($"Результат вычисления Аккермана: {res}");
}
else Console.WriteLine("Введены неверные данные...");