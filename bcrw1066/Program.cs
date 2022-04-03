using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());

        int positivo = 0;
        int negativo = 0;
        int pares = 0;
        int impares = 0;

        if (numero > 0)
        {
            positivo++;
        }
        else if (numero < 0)
        {
            negativo++;
        }
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
        
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivo++;
        }
        else if (numero < 0)
        {
            negativo++;
        }
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }

        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivo++;
        }
        else if (numero < 0)
        {
            negativo++;
        }
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }

        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivo++;
        }
        else if (numero < 0)
        {
            negativo++;
        }
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
        
        numero = int.Parse(Console.ReadLine());
        if (numero > 0)
        {
            positivo++;
        }
        else if (numero < 0)
        {
            negativo++;
        }
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }

        Console.WriteLine(pares + " valor(es) par(es)");
        Console.WriteLine(impares + " valor(es) impar(es)");
        Console.WriteLine(positivo + " valor(es) positivo(s)");
        Console.WriteLine(negativo + " valor(es) negativo(s)");
    }
}