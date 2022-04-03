using System; 

class Program
{

    static void Main(string[] args)
    { 

        int a, b, c, MaiorAB, maior;

        string[] valores = Console.ReadLine().Split(' ');

        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);

        MaiorAB = (a + b + Math.Abs(a - b)) / 2;

        maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

        Console.WriteLine($"{maior} eh o maior");

    }

}
