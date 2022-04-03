using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        
        string[] valores = Console.ReadLine().Split();

        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);

        double HotDog = 4.0;
        double xSalada = 4.50;
        double xBacon = 5.0;
        double Torrada = 2.0;
        double Refrigerante = 1.50;

        double quantidade = 0.0;

        if (a == 1)
        {
            quantidade = b * HotDog;
            Console.WriteLine("Total: R$ "+ quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (a == 2)
        {
            quantidade = b * xSalada;
            Console.WriteLine("Total: R$ "+ quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (a == 3)
        {
            quantidade = b * xBacon;
            Console.WriteLine("Total: R$ "+ quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (a == 4)
        {
            quantidade = b * Torrada;
            Console.WriteLine("Total: R$ "+ quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (a == 5)
        {
            quantidade = b * Refrigerante;
            Console.WriteLine("Total: R$ "+ quantidade.ToString("F2", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Codigo invalido");
        }
    }
}
