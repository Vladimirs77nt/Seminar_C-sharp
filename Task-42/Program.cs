// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertDeсToBinary (int num)
{
    string binary = "";
    while(num>0)
    {
        if (num % 2 == 0) binary = "0" + binary;
        else binary = "1" + binary;
        num = num / 2;
    }
    return (binary);
}

Console.WriteLine(number);
string res = ConvertDeсToBinary(number);
Console.WriteLine(res);