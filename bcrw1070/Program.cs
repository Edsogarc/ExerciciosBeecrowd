using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        int contador = 1;
        int voltas = 12;

        while (contador <= voltas)
        {
            if (x % 2 != 0)
            {
                Console.WriteLine(x);
            }
            x++;
            contador++;
        }
    }
}
