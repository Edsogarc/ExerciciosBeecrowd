using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    {
        
        string[] valores = Console.ReadLine().Split(' ');

        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double perimetro, area;

        if ((b - c < a && a < b + c) && (a - c < b && b < a + c) && (a - b < c && c < a + b)){
            perimetro = a + b + c;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
        }
        else{
            area = (a + b) / 2 * c;
            Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}