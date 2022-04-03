using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador < 10000)
        {
            if (contador % n == 2)
            {
                Console.WriteLine(contador);
            }
            contador++;
        }
    }
}