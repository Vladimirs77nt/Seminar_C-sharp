Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Remains(int a, int b)
{
    return a % b == 0;
}

if (Remains(number,7) && Remains(number,23)) Console.WriteLine("да");
else Console.WriteLine("нет");
