using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int cod1, qteP1,cod2, qteP2;
        double valorP1, valorP2, total;
        
        string[] valores = Console.ReadLine().Split(' ');
        cod1 = int.Parse(valores[0]);
        qteP1 = int.Parse(valores[1]);
        valorP1 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
        valores = Console.ReadLine().Split(' ');
        cod2 = int.Parse(valores[0]);
        qteP2 = int.Parse(valores[1]);
        valorP2 = double.Parse(valores[2], CultureInfo.InvariantCulture);
        
        total = (qteP1 * valorP1) + (qteP2 * valorP2);
        
        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
