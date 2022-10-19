// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double IntersectionPointX(double b1, double k1, double b2, double k2) // методы вычисления Y по заданным уравнениям
{
    double xpoint = (b2 - b1) / (k1 - k2);
    return xpoint;
}

Console.WriteLine();                                  // начало основной программы
Console.WriteLine("Вычисление точки пересечения двух прямых, заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine();

Console.Write("Введите значение b1: ");              // консольный ввод данных
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (k1 == k2)                                   // проверка коэффициентов k на одинаковое значение
{                                               // если они одинаковые - то линии параллельные, т.е. не пересекаются
    Console.WriteLine("Линии с заданными параметрами не пересекаются");
}
else
{                                                    // поиск точки пересечения
    double x = IntersectionPointX(b1, k1, b2, k2);   // вызов метода вычисления координаты Y (точка пересечения)
    double y = k1 * x + b1;                          // вычисление координаты X (точка пересечения)
    Console.WriteLine($"Координаты точки пересечения: x = {x}, y = {y}");
}