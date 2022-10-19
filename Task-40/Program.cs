// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите сторону треугольниа 1: ");
int lenght1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольниа 2: ");
int lenght2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольниа 3: ");
int lenght3 = Convert.ToInt32(Console.ReadLine());

// bool CheckTriangle (int num1, int num2, int num3)
// {
//     if (num1 <(num2+num3) && (num2 < (num1+num3)) && (num3 < (num1 + num2))) return true;
//     return false;
// }

bool CheckTriangle (int num1, int num2, int num3)
{
    return (num1 <(num2+num3) && (num2 < (num1+num3)) && (num3 < (num1 + num2)));
}

if (CheckTriangle (lenght1, lenght2, lenght3) == true) Console.WriteLine ("Да");
else Console.WriteLine ("Нет");
