using System; 

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int j = 60;

        while (j >= 0)
        {
            Console.WriteLine("I=" + i + " J=" + j);
            j = j - 5;
            i = i + 3;
        }
    }
}
