using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double[] vetor = new double[100];

        for (int i = 0; i < vetor.Length; i++)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vetor[i] = x;
            if (vetor[i] <= 10)
            {
                Console.WriteLine("A["+i+"]"+" = "+vetor[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}