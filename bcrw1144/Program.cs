using System; 

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int segundo;
        int terceiro;
        string sequecia = "";
        string sequecia1 = "";

        for (int i = 1; i <= n; i++)
        {
            segundo = i * i;
            terceiro = i * i * i;
            sequecia = segundo + " " + terceiro;
            sequecia1 = (segundo + 1) + " " + (terceiro + 1);
            Console.WriteLine(i + " " + sequecia);
            Console.WriteLine(i + " " + sequecia1);
        }
    }
}