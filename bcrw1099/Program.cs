﻿using System; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            int temp;

            if (x > y)
            {
                temp = x;
                x = y;
                y = temp;
            }

            int soma = 0;
            for (int j = x + 1; j < y; j++)
            {
                if (j % 2 != 0)
                {
                    soma = soma + j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}