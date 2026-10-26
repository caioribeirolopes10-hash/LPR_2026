using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> notas = new List<double>();

        Console.WriteLine("Digite 5 notas:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Nota {i}: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Valor inválido!");
                i--;
            }
        }

        Console.WriteLine($"Maior nota: {notas.Max()}");
        Console.WriteLine($"Menor nota: {notas.Min()}");
        Console.WriteLine($"Média: {notas.Average():F2}");
    }
}