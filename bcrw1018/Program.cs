using System; 

class Program
{

    static void Main(string[] args)
    {
        
        /* Passou no Beecrowd o outro não
        int N, quociente, resto, nota;

        N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);

        resto = N;

        nota = 100;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        nota = 50;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        nota = 20;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        nota = 10;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        nota = 5;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        nota = 2;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota +",00");
        resto = resto % nota;

        Console.WriteLine(resto + " nota(s) de R$ 1,00");
        */
        int n = int.Parse(Console.ReadLine());
        int[] notes = {100, 50, 20, 10, 5, 2, 1};

        int rest = n;
        int quotient = 0;
        foreach (int note in notes)
        {
            quotient = rest / note;
            Console.WriteLine(quotient + " nota (s) de R$ "+note+",00");
            rest = rest % note;
        }
    }

}
