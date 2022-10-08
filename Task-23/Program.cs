// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// 
// решение задачи без использования методов

Console.WriteLine("Введите число (от 1 и более): ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (number>0)
    {
    while (count <= number) 
        {
            Console.WriteLine($"{count} -> {Math.Pow(count,3)}");
            count++;
        }
    }
else Console.WriteLine("ошибка");