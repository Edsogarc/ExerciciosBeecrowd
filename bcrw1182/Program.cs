using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int c = int.Parse(Console.ReadLine());

        char t = char.Parse(Console.ReadLine());
        double[,] matriz = new double[12, 12];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                matriz[i, j] = x;
            }
        }
        double media = 0;
        double soma = 0.0;
        for (int i = 0; i < 12; i++)
        {
            if (t == 'S')
            {
                soma = soma + matriz[i, c];
            }
            else if (t == 'M')
            {
                soma = soma + matriz[i, c];
            }
        }
        if (t == 'S')
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            media = soma / 12.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}