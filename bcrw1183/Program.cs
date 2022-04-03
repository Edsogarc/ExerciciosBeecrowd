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
        int Coluna = 1;
        int decremento = 11;
        for (int Linha = 0; Linha < n - 1; Linha++)
        {
            while (Coluna < n)
            {
                soma = soma + matriz[Linha, Coluna];
                Coluna++;
            }
            decremento--;
            Coluna = Coluna - decremento;
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