// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarte = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(quarte));

string Range(int quarte)
{
    if (quarte == 1) return "x - положительные, y - положительные";
    if (quarte == 2) return "x - отрицательные, y - положительные";
    if (quarte == 3) return "x - отрицательные, y - отрицательные";
    if (quarte == 4) return "x - положительные, y - отрицательные";
    return "неверная четверть";
}