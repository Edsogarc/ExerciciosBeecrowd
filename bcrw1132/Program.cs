using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int temp = 0;
        int soma = 0;
        if (x > y)
        {
            temp = x;
            x = y;
            y = temp;
        }

        while (x <= y)
        {
            if (x % 13 != 0)
            {
                soma = soma + x;
            }
            x++;
        }
        Console.WriteLine(soma);
    }
}