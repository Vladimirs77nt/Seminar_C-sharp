// Задача 42: Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Binary(int num)
{
    int temp = 0;
    int count = 1;
    while (num > 0) 
    {
        temp = temp + num % 2 * count; 
        num = num / 2; 
        count = count * 10; 
    }
    return temp;
}

int binary = Binary(number);
Console.WriteLine($"{number} -> {binary}");
