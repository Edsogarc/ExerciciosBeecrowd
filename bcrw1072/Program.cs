using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int contador = 1;
        int dentro = 0;
        int fora = 0;

        while (contador <= n)
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
            contador++;
        }
        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }
}
