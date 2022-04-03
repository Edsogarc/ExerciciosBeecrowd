using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int soma;
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            soma = 0;
            for (int j = 1; j < x; j++)
            {
                if (x % j == 0)
                {
                    soma = soma + j;
                }
            }
            if (soma == x)
            {
                Console.WriteLine(soma + " eh perfeito");
            }
            else
            {
                Console.WriteLine(x + " nao eh perfeito");
            }
        }
    }
}
