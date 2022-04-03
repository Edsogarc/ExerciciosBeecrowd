using System; 

class Prpgram
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        int quantidade = 0;

        if (n1 % 2 == 0)
        {
            quantidade++;
        }
        if (n2 % 2 == 0)
        {
            quantidade++;
        }
        if (n3 % 2 == 0)
        {
            quantidade++;
        }
        if (n4 % 2 == 0)
        {
            quantidade++;
        }
        if (n5 % 2 == 0)
        {
            quantidade++;
        }

        Console.WriteLine(quantidade + " valores pares");
    }
}