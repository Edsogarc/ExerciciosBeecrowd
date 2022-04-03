using System; 

class Program
{
    static void Main(string[] args)
    {
        int opcao = 1;
        int vitoriaInter = 0;
        int vitoriaGremio = 0;
        int empate = 0;
        string vencedor = "";
        int grenal = 0;

        while (opcao == 1)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int golInter = int.Parse(valores[0]);
            int golGremio = int.Parse(valores[1]);

            if (golInter > golGremio)
            {
                vitoriaInter = vitoriaInter + 1;
            }
            else if (golInter < golGremio)
            {
                vitoriaGremio = vitoriaGremio + 1;
            }
            else if (golInter == golGremio)
            {
                empate = empate + 1;
            }
            if (vitoriaInter > vitoriaGremio)
            {
                vencedor = "Inter";
            }
            else
            {
                vencedor = "Gremio";
            }
            grenal = grenal + 1;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            opcao = int.Parse(Console.ReadLine());
            while (opcao < 1 || opcao > 2)
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine(grenal + " grenais");
        Console.WriteLine("Inter:" + vitoriaInter);
        Console.WriteLine("Gremio:" + vitoriaGremio);
        Console.WriteLine("Empates:" + empate);
        Console.WriteLine(vencedor + " venceu mais");
    }
}
