using System; 

class Program
{

    static void Main(string[] args)
    { 

        double R, pi, volume;
        
        R = double.Parse(Console.ReadLine());
        pi = 3.14159;
        
        volume = (4/3.0) * pi * R * R * R;
        
        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");

    }
}
