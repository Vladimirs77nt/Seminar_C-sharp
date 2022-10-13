// Задача 28. Напишите программу, которая принимает на вход
// число (А) и выдает произведение чисел от 1 до А.
// 4 -> 24
// 5 -> 120

Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int multNumber = MultNum(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multNumber}");

int MultNum (int a)
{
    int mult_num = 1;
    for (int i = 1; i <= a; i++)
    {
        mult_num *= i;
    }
    return mult_num;
}