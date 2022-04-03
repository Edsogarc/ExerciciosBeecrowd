using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int primeiro;
        int segundo;
        int terceiro;
        string quadrado = "";

        for (int i = 1; i <= n; i++)
        {
            primeiro = i;
            segundo = i * i;
            terceiro = i * i * i;
            quadrado = primeiro +" "+ segundo +" "+ terceiro;
            Console.WriteLine(quadrado);
        }
    }
}