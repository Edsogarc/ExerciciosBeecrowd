using System; 

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        for (int i = 0; i < vetor.Length ; i++)
        {
            int x = int.Parse(Console.ReadLine());
            vetor[i] = x;
            if (vetor[i] <= 0)
            {
                vetor[i] = 1;
            }
        }
        for (int a = 0; a < 10; a++)
        {
            Console.WriteLine("X"+"["+a+"]"+" = "+vetor[a]);
        }
    }
}