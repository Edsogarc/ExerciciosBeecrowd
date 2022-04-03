using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    { 

        int tempo, velocidade;
        double litros;

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        litros = (tempo * velocidade) / 12.0;

        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

    }

}
