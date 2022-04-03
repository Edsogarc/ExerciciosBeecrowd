using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int soma = 0;
        double media = 0.0;
        int contador = 0;
        
        while (n > 0)
        {
            soma = soma + n;
            contador++;
            n = int.Parse(Console.ReadLine());

        }
        media = (double)soma / contador;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

    }
}
