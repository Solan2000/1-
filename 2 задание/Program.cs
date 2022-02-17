using System;
class HelloWorld
{
    static void Main()
    {
        int n, m;
        int k = 0;
        n = Int32.Parse(Console.ReadLine());
        m = Int32.Parse(Console.ReadLine());
        while (n>=m)
        {
            n -= m;
            k++;
        }
        Console.WriteLine($"Частное:  {k}, остаток: {n}");
    }
}
