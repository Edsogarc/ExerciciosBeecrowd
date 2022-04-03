using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int soma;
        int contador;

        while (x != 0)
        {
            soma = 0;
            contador = 1;
            while (contador <= 5)
            {
                if (x % 2 == 0)
                {
                    soma = soma + x;
                    x += 2;
                }
                else
                {
                    x++;
                    contador--;
                }
                contador++;
            }
            Console.WriteLine(soma);
            x = int.Parse(Console.ReadLine());
        }
    }
}