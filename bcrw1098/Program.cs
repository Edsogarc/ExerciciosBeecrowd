using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double i, k;
        double j;
        for (i = 0; i < 2.1; i+=0.2)
        {
            for (j = 1; j <=3; j++)
            {
                k = i + j;
                if (i == 0 || i > 1.8 || (i > 0.9 && i < 1.1))
                {
                    Console.WriteLine("I="+i.ToString("F0", CultureInfo.InvariantCulture)+" J="+k.ToString("F0", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("I="+i.ToString("F1", CultureInfo.InvariantCulture)+" J="+k.ToString("F1", CultureInfo.InvariantCulture));                    
                }               
            }
        }
    }
}
