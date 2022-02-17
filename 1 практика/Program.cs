using System;
class HelloWorld
{
    static void Main()
    {
        double p = Double.Parse(Console.ReadLine());
        double h = Double.Parse(Console.ReadLine());
        double s = 0;
        for (int i = 0; i < 10; i++)
        {
            s += ((p + i * h) * (p * i * h));
        }
        Console.WriteLine(s);
    }
}
