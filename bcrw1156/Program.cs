using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int i;
        double soma = 0;
        double contador = 1.0;
        for (i = 1; i <= 39; i += 2)
        {
            soma = soma + i / contador;
            contador = contador * 2.0;
        }
        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}