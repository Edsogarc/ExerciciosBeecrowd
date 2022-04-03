using System; 

class Program
{

    static void Main(string[] args)
    {
        
        string[] valores = Console.ReadLine().Split(' ');

        int horaInicio = int.Parse(valores[0]);
        int horaFinal = int.Parse(valores[1]);

        int horas = 24;
        int duracao;

        if (horaInicio < horaFinal)
        {
            duracao = horaFinal - horaInicio;
        }
        else
        {
            duracao = horas - horaInicio + horaFinal;
        }
        Console.WriteLine("O JOGO DUROU "+ duracao + " HORA(S)");

    }

}
