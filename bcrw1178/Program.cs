using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        decimal x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal[] n = new decimal[100];
        n[0] = x;
        int contador = 0;
        for (int i = 1; i < 100; i++)
        {
            n[i] = n[contador] / 2;
            contador++;
        }
        for (int j = 0; j < 100; j++)
        {
            Console.WriteLine("N["+j+"]"+" = "+decimal.Round(n[j], 4, MidpointRounding.ToEven));
        }
    }
}