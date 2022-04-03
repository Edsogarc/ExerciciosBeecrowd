using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[10];
        vetor[0] = n;
        for (int i = 1; i < vetor.Length; i++)
        {
            vetor[i] = vetor[i - 1] * 2;
        }
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("N[" +j+ "]"+" = "+vetor[j]);            
        }
    }
}