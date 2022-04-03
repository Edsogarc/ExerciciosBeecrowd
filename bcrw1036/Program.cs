using System; 
using System.Globalization;

class Program 
{

    static void Main(string[] args)
    { 
        
        string[] valores = Console.ReadLine().Split(' ');

        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double delta = (B * B) - (4 * A * C);
        double raiz = Math.Sqrt(delta);
        double x1 = ((- B) + raiz) / (2 * A);
        double x2 = ((- B) - raiz) / (2 * A);

        if (delta < 0.0 || raiz < 0.0 || A == 0.0 || B == 0.0 || C == 0.0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = "+ x1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = "+ x2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
