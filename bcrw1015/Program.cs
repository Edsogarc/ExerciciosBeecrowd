using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    { 

        double x1, x2, y1, y2, p1, p2, resultado;

        string[] valores = Console.ReadLine().Split(' ');
        x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

        p1 = Math.Pow(x2 - x1, 2);
        p2 = Math.Pow(y2 - y1, 2);

        resultado = Math.Sqrt(p1 + p2);

        Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));

    }

}
