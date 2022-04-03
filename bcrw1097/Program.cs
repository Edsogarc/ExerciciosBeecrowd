using System; 

class Program
{
    static void Main(string[] args)
    {
        int acrescimo = 7;
        int j;
        for (int i = 1; i <= 9; i = i + 2)
        {
            for (j = acrescimo; j >= i + 4 ; j--)
            {
                Console.WriteLine("I=" + i + " J=" + j);
            }
            acrescimo = j + 5;
        }
    }
}
