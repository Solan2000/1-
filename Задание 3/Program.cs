using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        for (double a = Math.PI/5; a < Math.PI; a+= Math.PI/25)
        {
            Console.WriteLine ($" \t {a},\t {Y(a)}");
        }
        Console.Read();
    }
    static double Sequencesum(double x)
    {
        Func<double, int, double> member = (z, i) => Math.Pow(-1, i) * (Math.Cos(i * x) / Math.Pow(i, 2));
        double epsilon = 0.0001, sum = 0;
        for (int j = 1; ; j++)
        {
            double m = member(x, j);
            if (m < epsilon) ;
                break;
            sum += m;

        }
        return sum;
    }
    static double Y(double x)
    {
        return (Math.Pow(x, 2) - (Math.Pow(Math.PI, 2) / 3)) / 4;
    }
}
