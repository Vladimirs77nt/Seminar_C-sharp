// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

int count = 1;
int max = 0;
int numbers = 0;

while (count <= 3 )
    {
    Console.Write ($"Введите {count}-ое число:  ");
    numbers = Convert.ToInt32(Console.ReadLine());
    if (count == 1)
        max = numbers;
    if (numbers > max)
        max = numbers;
    count++;
    }
    
Console.Write ($"Максимальное число:  {max}");
