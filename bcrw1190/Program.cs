using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        char O = char.Parse(Console.ReadLine());
        int n = 12;
        double[,] matriz = new double[n, n];
        double media = 0;
        double soma = 0;
        for (int linha = 0; linha < n; linha++)
        {
            for (int coluna = 0; coluna < n; coluna++)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                matriz[linha, coluna] = x;
            }
        }
        int incremento = 0;
        int decremento = 11;
        for (int Coluna = 11; Coluna > 6; Coluna--)
        {
            for (int Linha = 1 + incremento; Linha < decremento; Linha++)
            {
                soma = soma + matriz[Linha, Coluna];
            }
            decremento--;
            incremento++;
        }
        if (O == 'S')
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            media = soma / 5;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}