using System;
class Program
{
    static void Main(string[] args)
    {
        int numero, horas;
        double valor, salario;
        
        numero = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valor = double.Parse(Console.ReadLine());
        
        salario = valor * horas;
        
        Console.WriteLine($"NUMBER = {numero}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
    }
}