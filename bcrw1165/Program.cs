using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int contador = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            for (int j = 1; j <= x; j++)
            {
                if (x % j == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                Console.WriteLine(x + " eh primo");
            }
            else
            {
                Console.WriteLine(x + " nao eh primo");
            }
            contador = 0;
        }
    }
}