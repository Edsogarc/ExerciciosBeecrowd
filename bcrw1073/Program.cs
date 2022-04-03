using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int contador = 1;
        int multiplicador;

        while (contador <= n)
        {
            if (contador % 2 == 0)
            {
                multiplicador = contador * contador;
                Console.WriteLine(contador + "^2 = " + multiplicador);
            }
            contador++;
        }
    }
}
