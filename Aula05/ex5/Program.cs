
using System;

class Program
{
    static void Main()
    {
        float horasPorDia;
        float totalHoras = 0;
        int dias = 0;
        int semanas = 0;
        float meses;

        Console.Write("Digite quantas horas de treinamento por dia: ");
        horasPorDia = float.Parse(Console.ReadLine());

        while (totalHoras < 1000)
        {
            for (int i = 1; i <= 5; i++)
            {
                totalHoras += horasPorDia;
                dias++;

                if (totalHoras >= 1000)
                {
                    break;
                }
            }

            semanas++;
        }

        meses = semanas / 4.5f;

        Console.WriteLine("\nTreinamento concluido!");
        Console.WriteLine("Total de dias de treinamento: " + dias);
        Console.WriteLine("Total de semanas: " + semanas);
        Console.WriteLine("Total de meses: " + meses);

        Console.ReadKey();
    }
}


