// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Fibonacci (int num)
{
    int tmp = 0;
    int num1 = 0;
    Console.Write("0 1 ");
    int num2 = 1;
    for (int i = 2; i < num; i++)
    {
        Console.Write(num1+num2);
        Console.Write(" ");
        tmp = num2;
        num2 = num1 + num2;
        num1 = tmp;
    }
}

Fibonacci (number);