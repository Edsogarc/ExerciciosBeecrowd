using System; 

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int soma = 0;
        int contador = 1;

        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }
        soma = x;
        for (int i = 1; soma < z; i++)
        {
            x = x + 1;
            contador++;
            soma = soma + x;
        }
        Console.WriteLine(contador);
    }
}
