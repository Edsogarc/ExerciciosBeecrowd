using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        char t = char.Parse(Console.ReadLine());
        int n = 12;
        decimal[,] matriz = new decimal[n, n];
        decimal media = 0;
        decimal soma = 0;
        for (int linha = 0; linha < n; linha++)
        {
            for (int coluna = 0; coluna < n; coluna++)
            {
                decimal x = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                matriz[linha, coluna] = x;
            }
        }
        int Linha = 1;
        int decremento = 11;
        for (int Coluna = 0; Coluna < n; Coluna++)
        {
            while (Linha < n)
            {
                soma = soma + matriz[Linha, Coluna];
                Linha++;
            }
            decremento--;
            Linha = Linha - decremento;
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
