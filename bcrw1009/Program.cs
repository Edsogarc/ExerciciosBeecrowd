using System;
using System.Globalization;

class Program
{

    static void Main(string[] args)
    { 

        string vendedor;
        double salario, vendas, comissao;
        
        vendedor = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        comissao = ((vendas * 15.0)/100.0) + salario;
        
        Console.WriteLine($"TOTAL = R$ {comissao.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}
