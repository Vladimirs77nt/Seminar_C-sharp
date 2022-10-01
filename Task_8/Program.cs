// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число от 1 и больше: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1)
    {
    int count = 2;
    while (count <= number)
        {
        Console.Write (count);
        count = count + 2;
        if (count <= number)
            Console.Write (", ");
        }
    }
else
    Console.Write("Вы ввели неправильное число.");