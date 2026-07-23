using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        int numero;
        int contador = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite o número que deseja pesquisar: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] == numero)
            {
                Console.WriteLine("Encontrado na posição " + i);
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine("Quantidade de ocorrências: " + contador);
        }
        else
        {
            Console.WriteLine("Número não encontrado.");
        }
    }
}