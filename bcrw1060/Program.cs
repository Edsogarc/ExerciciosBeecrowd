using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int quantidade = 0;

        if (a > 0.0)
        {
            quantidade++;
        }
        if (b > 0.0)
        {
            quantidade++;
        }
        if (c > 0.0)
        {
            quantidade++;
        }
        if (d > 0.0)
        {
            quantidade++;
        }
        if (e > 0.0)
        {
            quantidade++;
        }
        if (f > 0.0)
        {
            quantidade++;
        }
        Console.WriteLine(quantidade + " valores positivos");
    }
}