using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int contador = 1;
        int soma = 0;
        int min, max;

        if (x < y)
        {
            min = x;
            max = y;
        }
        else
        {
            min = y;
            max = x;
        }
        contador = min + 1;
        while (contador < max)
        {
            if (contador % 2 != 0)
            {
                soma = soma + contador;
            }
            contador++;
        }
        Console.WriteLine(soma);
    }
}
