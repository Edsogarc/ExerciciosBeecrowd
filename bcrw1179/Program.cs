using System; 

class Program
{
    static void Main(string[] args)
    {
        int[] par = new int[5];
        int[] impar = new int[5];
        int contador = 0;
        int contador1 = 0;

        for (int i = 0; i < 15; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                par[contador] = x;
                contador++;
            }
            else
            {
                impar[contador1] = x;
                contador1++;
            }
            if (contador == 5)
            {
                for (int j = 0; j < contador; j++)
                {
                    Console.WriteLine("par[" + j + "]" + " = " + par[j]);
                }
                contador = 0;
            }
            if (contador1 == 5)
            {
                for (int j = 0; j < contador1; j++)
                {
                    Console.WriteLine("impar[" + j + "]" + " = " + impar[j]);
                }
                contador1 = 0;
            }
        }
        for (int w = 0; w < contador1; w++)
        {
            Console.WriteLine("impar[" + w + "]" + " = " + impar[w]);
        }
        for (int x = 0; x < contador; x++)
        {
            Console.WriteLine("par[" + x + "]" + " = " + par[x]);
        }
    }
}