using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int contador = 1;
        int resultado;

        while (contador <= 10)
        {
            resultado = contador * n;
            Console.WriteLine(contador + " x " + n + " = " + resultado);
            contador++;

        }
    }
}
