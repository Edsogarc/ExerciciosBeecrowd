using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int contador = 1;

        string positivo = "POSITIVE";
        string negativo = "NEGATIVE";
        string pares = "EVEN";
        string impares = "ODD";
        string zero = "NULL";

        string mensagem = "";

        while (contador <= n)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                mensagem = pares;
            }
            else
            {
                mensagem = impares;
            }
            if (x > 0)
            {
                mensagem = mensagem + " " + positivo;
            }
            else
            {
                mensagem = mensagem + " " + negativo;
            }
            if (x == 0)
            {
                mensagem = zero;
            }
            Console.WriteLine(mensagem);
            contador++;
        }
    }
}
