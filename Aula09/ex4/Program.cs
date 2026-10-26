using System;
using System.Collections.Generic;

struct Piloto
{
    public string Nome;
    public string Equipe;
    public int Pontuacao;
}

class Program
{
    static List<Piloto> pilotos = new List<Piloto>();

    static void CadastrarPiloto()
    {
        for (int i = 0; i < 10; i++)
        {
            Piloto p = new Piloto();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Equipe: ");
            p.Equipe = Console.ReadLine();

            Console.Write("Pontuação: ");
            p.Pontuacao = int.Parse(Console.ReadLine());

            pilotos.Add(p);

            Console.WriteLine();
        }
    }

    static void ExibirRanking()
    {
        pilotos.Sort((a, b) => b.Pontuacao.CompareTo(a.Pontuacao));

        Console.WriteLine("\nRANKING\n");

        foreach (Piloto p in pilotos)
        {
            Console.WriteLine(p.Nome + " - " + p.Equipe + " - " + p.Pontuacao + " pontos");
        }
    }

    static double CalcularPontuacaoMedia()
    {
        int soma = 0;

        foreach (Piloto p in pilotos)
        {
            soma += p.Pontuacao;
        }

        return (double)soma / pilotos.Count;
    }

    static void ExibirMelhorEquipe()
    {
        string melhorEquipe = "";
        int maiorPontuacao = 0;

        for (int i = 0; i < pilotos.Count; i++)
        {
            int soma = 0;

            for (int j = 0; j < pilotos.Count; j++)
            {
                if (pilotos[i].Equipe == pilotos[j].Equipe)
                {
                    soma += pilotos[j].Pontuacao;
                }
            }

            if (soma > maiorPontuacao)
            {
                maiorPontuacao = soma;
                melhorEquipe = pilotos[i].Equipe;
            }
        }

        Console.WriteLine("\nMelhor equipe: " + melhorEquipe);
        Console.WriteLine("Total de pontos: " + maiorPontuacao);
    }

    static void Main()
    {
        CadastrarPiloto();

        ExibirRanking();

        double media = CalcularPontuacaoMedia();

        Console.WriteLine("\nMédia de pontos: " + media);

        int acimaMedia = 0;

        foreach (Piloto p in pilotos)
        {
            if (p.Pontuacao > media)
            {
                acimaMedia++;
            }
        }

        Console.WriteLine("Pilotos acima da média: " + acimaMedia);

        ExibirMelhorEquipe();
    }
}