// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введиде число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиде степень: ");
int num_B = Convert.ToInt32(Console.ReadLine());

int num_Degree = Degree(num_A, num_B);
Console.WriteLine($"{num_A}, {num_B} -> {num_Degree}");

int Degree(int a, int b) // метод возведения в степень
{
    int result = 1;
    if (b < 0) // проверка на отрицательные числа
        {
        Console.WriteLine("Ошибка ввода степени!");
        result = 0;
        }
    else if (b == 0) Console.WriteLine ("Любое число в степени 0 равно 1"); // проверка на степень 1
    else
    {
        for (int i = 0; i < b; i++)
        {
        result = result * a; // возведение в степень...
        }
    }
    return result;
}