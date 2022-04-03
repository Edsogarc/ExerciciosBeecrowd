using System; 

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int temp;

        if (x > y)
        {
            temp = x;
            x = y;
            y = temp;
        }
        int incremento = x + 1;

        while (incremento < y)
        {
            if (incremento % 5 == 2 || incremento % 5 == 3)
            {
                Console.WriteLine(incremento);
            }
            incremento++;
        }
    }
}
