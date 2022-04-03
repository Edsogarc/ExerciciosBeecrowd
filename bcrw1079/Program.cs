using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int contador = 0;

        while (contador < n)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double n1 = double.Parse(valores[0]);
            double n2 = double.Parse(valores[1]);
            double n3 = double.Parse(valores[2]);

            double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            contador++;
        }
    }
}
