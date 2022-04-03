using System; 

class Program
{
    static void Main(string[] args)
    {
        string[] dataInicio = Console.ReadLine().Split(' ');

        int diaInicio = int.Parse(dataInicio[1]);

        string[] horarioInicio = Console.ReadLine().Split(' ');

        int hora1 = int.Parse(horarioInicio[0]);
        int minuto1 = int.Parse(horarioInicio[2]);
        int segundo1 = int.Parse(horarioInicio[4]);

        string[] dataFim = Console.ReadLine().Split(' ');

        int diaFim = int.Parse(dataFim[1]);

        string[] horarioFim = Console.ReadLine().Split(' ');

        int hora2 = int.Parse(horarioFim[0]);
        int minuto2 = int.Parse(horarioFim[2]);
        int segundo2 = int.Parse(horarioFim[4]);

        int inicio = (diaInicio - 1) * 24 * 60 * 60 + hora1 * 60 * 60 + minuto1 * 60 + segundo1;
        int fim = (diaFim - 1) * 24 * 60 * 60 + hora2 * 60 * 60 + minuto2 * 60 + segundo2;

        int duracao = fim - inicio;

        int Dia = duracao / (24 * 60 * 60);
        int resto = duracao % (24 * 60 * 60);
        int Horas = resto / (60 * 60);
        resto = resto % (60 * 60);
        int Minutos = resto / 60;
        int Segundos = resto % 60;

        Console.WriteLine(Dia + " dia(s)");
        Console.WriteLine(Horas + " hora(s)");
        Console.WriteLine(Minutos + " minuto(s)");
        Console.WriteLine(Segundos + " segundo(s)");

    }
}