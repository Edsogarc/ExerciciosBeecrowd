﻿using System; 

class Program
{

    static void Main(string[] args)
    { 

        int N, minutos, horas, segundos, resto;

        N = int.Parse(Console.ReadLine());

        horas = N / 3600;
        resto = N % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);

    }

}
