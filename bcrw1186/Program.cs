using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        char t = char.Parse(Console.ReadLine());
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
        int decremento = 0;
        for (int Linha = 1; Linha < 12; Linha++)
        {
            for (int Coluna = 11 - decremento; Coluna < 12; Coluna++)
            {
                soma = soma + matriz[Linha, Coluna];
            }
            decremento++;
        }
        if (t == 'S')
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            media = soma / 11;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}