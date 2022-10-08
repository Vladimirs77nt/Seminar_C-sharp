// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.Write($"{day} -> ПОНЕДЕЛЬНИК");
}
if (day == 2)
{
    Console.Write($"{day} -> ВТОРНИК");
}
if (day == 3)
{
    Console.Write($"{day} -> СРЕДА");
}
if (day == 4)
{
    Console.Write($"{day} -> ЧЕТВЕРГ");
}
if (day == 5)
{
    Console.Write($"{day} -> ПЯТНИЦА");
}
if (day == 6)
{
    Console.Write($"{day} -> СУББОТА");
}
if (day == 7)
{
    Console.Write($"{day} -> ВОСКРЕСЕНЬЕ");
}
if (day > 7)
{
    Console.Write($"{day} -> такого дня недели нет");
}