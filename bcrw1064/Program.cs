using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int quantidade = 0;
        double numeros = 0.0;

        if (n1 > 0.0)
        {
            quantidade++;
            numeros = n1;
        }
        if (n2 > 0.0)
        {
            quantidade++;
            numeros = numeros + n2;
        }
        if (n3 > 0.0)
        {
            quantidade++;
            numeros = numeros + n3;
        }
        if (n4 > 0.0)
        {
            quantidade++;
            numeros = numeros + n4;
        }
        if (n5 > 0.0)
        {
            quantidade++;
            numeros = numeros + n5;
        }
        if (n6 > 0.0)
        {
            quantidade++;
            numeros = numeros + n6;
        }

        double media = numeros / quantidade;

        Console.WriteLine(quantidade + " valores positivos");
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}
