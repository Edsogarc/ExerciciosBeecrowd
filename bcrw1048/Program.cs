using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double novoSalario, ajuste, percentual = 0.0;

        if (salario > 0.0 && salario <= 400.00)
        {
            novoSalario = (salario * 0.15) + salario;
            ajuste = salario * 0.15;
            percentual = ((novoSalario * 100.0) / salario) - 100;
        }
        else if (salario > 400.0 && salario <= 800.0)
        {
            novoSalario = (salario * 0.12) + salario;
            ajuste = salario * 0.12;
            percentual = ((novoSalario * 100.0) / salario) - 100;
        }
        else if (salario > 800.0 && salario <= 1200.0)
        {
            novoSalario = (salario * 0.10) + salario;
            ajuste = salario * 0.10;
            percentual = ((novoSalario * 100.0) / salario) - 100;
        }
        else if (salario > 1200.0 && salario <= 2000.0)
        {
            novoSalario = (salario * 0.07) + salario;
            ajuste = salario * 0.07;
            percentual = ((novoSalario * 100.0) / salario) - 100;
        }
        else
        {
            novoSalario = (salario * 0.04) + salario;
            ajuste = salario * 0.04;
            percentual = ((novoSalario * 100.0) / salario) - 100;
        }
        Console.WriteLine("Novo salario: "+ novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: "+ ajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: "+ percentual.ToString("F0") + " %");
    }
}
