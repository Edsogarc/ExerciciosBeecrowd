using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= x)
        {
            if (!(contador % 2 == 0))
            {
                Console.WriteLine(contador);
            }
            contador++;
        }
    }
}
