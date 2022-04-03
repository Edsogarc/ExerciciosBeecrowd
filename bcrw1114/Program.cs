using System; 

class Program
{
    static void Main()
    {
        int senha = 2002;
        int acesso = int.Parse(Console.ReadLine());
        string permissao = "";

        while (senha != acesso)
        {
            permissao = "Senha Invalida";
            Console.WriteLine(permissao);
            acesso = int.Parse(Console.ReadLine());
        }
        permissao = "Acesso Permitido";
        Console.WriteLine(permissao);
    }
}