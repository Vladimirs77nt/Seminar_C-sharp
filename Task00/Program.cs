Random rnd = new Random();
int a;
for (int i = 0; i < 10; i++)
{
    a = rnd.Next(100);
    Console.WriteLine (a);
    // Console.WriteLine (new Random().Next (10));
}
