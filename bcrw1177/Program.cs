using System; 

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        int[] n = new int[t];
        int i, j = 0;
        for (j = 0; j < t; j++)
        {
            n[j] = j;
        }
        int contador = 0;
        for (i = 0; i < 1000; i++)
        {
            Console.WriteLine("N[" + i + "]" + " = " + n[contador]);
            contador++;
            if (contador == t)
            {
                contador = 0;
            }
        }
    }
}