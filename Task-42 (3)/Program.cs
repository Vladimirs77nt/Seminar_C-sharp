Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string DecToBin(int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        result = Convert.ToString(number % 2) + result;
        number = number / 2;
    }
    return result;
}

string decToBin = DecToBin(num);
Console.WriteLine(decToBin);
