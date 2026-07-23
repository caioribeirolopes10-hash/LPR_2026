using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        Console.Write("Quantas pessoas deseja cadastrar? ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas.Add(nome, idade);
        }

        int soma = 0;
        foreach (var pessoa in pessoas)
        {
            soma += pessoa.Value;
        }

        double media = (double)soma / pessoas.Count;

        Console.WriteLine("\nPessoas acima da média:");

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine(pessoa.Key + " - " + pessoa.Value + " anos");
            }
        }

        string maisVelha = "";
        string maisNova = "";
        int maior = -1;
        int menor = 200;

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > maior)
            {
                maior = pessoa.Value;
                maisVelha = pessoa.Key;
            }

            if (pessoa.Value < menor)
            {
                menor = pessoa.Value;
                maisNova = pessoa.Key;
            }
        }

        Console.WriteLine("\nPessoa mais velha: " + maisVelha);
        Console.WriteLine("Pessoa mais nova: " + maisNova);

        Console.Write("\nDigite uma idade para remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == y)
            {
                remover.Add(pessoa.Key);
            }
        }

        foreach (string nome in remover)
        {
            pessoas.Remove(nome);
        }

        Console.WriteLine("\nDicionário atualizado:");

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa.Key + " - " + pessoa.Value + " anos");
        }
    }
}

