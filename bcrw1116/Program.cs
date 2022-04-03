using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double divisao = 0;

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (y != 0)
            {
                divisao = (double)x / y;
                Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("divisao impossivel");
            }
        }
    }
}
