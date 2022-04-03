using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = 100;
        int i = 1;
        while (i <= n)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}
