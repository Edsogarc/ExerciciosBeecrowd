using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int contador;

        for (int i = 1; i <= n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int soma = 0;

            contador = 1;
            while (contador <= y)
            {
                if (x % 2 != 0)
                {
                    soma = soma + x;
                    x+=2;
                }
                else if (x % 2 == 0)
                {
                    x++;
                    contador--;                    
                }    
                contador++;
            }
            Console.WriteLine(soma);
        }
    }
}