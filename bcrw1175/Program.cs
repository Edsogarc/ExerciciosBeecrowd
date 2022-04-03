using System; 

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[20];
        int x, temp, i;
        for (i = 0; i < 20; i++)
        {
            x = int.Parse(Console.ReadLine());
            vetor[i] = x;
        }
        for (i = 0; i < 20 / 2; i++)
        {
            temp = vetor[i];
            vetor[i] = vetor[19 - i];
            vetor[19 - i] = temp;
        }
        for (i = 0; i < 20; i++)
        {
            Console.WriteLine("N["+i+"]"+" = "+vetor[i]);
        }
    }
}