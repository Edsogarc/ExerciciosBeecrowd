using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 1;
        while (opcao == 1)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            int descisao = int.Parse(Console.ReadLine());
            opcao = descisao;
            while (opcao < 1 || opcao > 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                descisao = int.Parse(Console.ReadLine());
                opcao = descisao;
            }
            if (opcao == 1)
            {
                opcao--;
                opcao++;
            }
            else
            {
                break;
            }
        }
    }
}