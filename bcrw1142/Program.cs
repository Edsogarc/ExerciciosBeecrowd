using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int incremento = 1;
        string valores = "";

        for (int i = n; i >= 1; i--)
        {
            valores = "";
            for (int j = 1; j <= 3; j++)
            {
                valores = valores + incremento + " ";
                incremento++;
            }
            Console.WriteLine(valores + "PUM");
            incremento = incremento + 1;
        }
    }
}
