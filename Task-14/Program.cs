// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// bool Remains (int number_A, int number_B)
//     {
//     int res = number_A % number_B;
//     if (res == 0) return true;
//     else return false;
//     }

bool Remains (int number_A, int number_B)
    {
    return number_A % number_B == 0;
    }

    if (Remains (a, 7) && Remains (a, 23)) Console.WriteLine ("Да");
    else Console.WriteLine ("Нет");