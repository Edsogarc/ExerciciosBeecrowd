using System; 

class Program
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');

        int m = int.Parse(valores[0]);
        int n = int.Parse(valores[1]);

        while (m > 0 && n > 0)
        {
            int temp;

            if (m > n)
            {
                temp = m;
                m = n;
                n = temp;
            }
            int soma = 0;
            string guardador = "";

            for (int i = m; i <= n; i++)
            {
                soma = soma + i;
                guardador = guardador + i + " ";
            }
            Console.WriteLine(guardador + "Sum=" + soma);

            valores = Console.ReadLine().Split(' ');
            m = int.Parse(valores[0]);
            n = int.Parse(valores[1]);
        }
    }
}