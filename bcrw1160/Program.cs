using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 1; i <= t; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int PA = int.Parse(valores[0]);
            int PB = int.Parse(valores[1]);

            double G1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double G2 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            int aumentoA = PA;
            int aumentoB = PB;

            int anos = 0;

            while (aumentoA <= aumentoB)
            {
                aumentoA = aumentoA + (int)(aumentoA * (G1 / 100));
                aumentoB = aumentoB + (int)(aumentoB * (G2 / 100));
                anos = anos + 1;
            }
            if (anos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine(anos + " anos.");
            }
        }
    }
}