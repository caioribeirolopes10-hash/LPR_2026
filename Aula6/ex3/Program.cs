using System;

class Program
{
    static string nome1, nome2, nome3, nome4, nome5;
    static string poder1, poder2, poder3, poder4, poder5;

    static int pontos1, pontos2, pontos3, pontos4, pontos5;

    static string equipe1, equipe2, equipe3;
    static string poderEquipe1, poderEquipe2, poderEquipe3;
    static int pontosEquipe1, pontosEquipe2, pontosEquipe3;

    static int quantidadeHerois = 0;

    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            mostrarMenu();
            opcao = escolherOpcao();

            executarOpcao(opcao);

        } while (opcao != 4);
    }

    static void mostrarMenu()
    {
        Console.WriteLine("\n=== MENU MARVEL ===");
        Console.WriteLine("1 - Cadastrar herói");
        Console.WriteLine("2 - Selecionar equipe");
        Console.WriteLine("3 - Exibir equipe");
        Console.WriteLine("4 - Sair");
    }

    static int escolherOpcao()
    {
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void executarOpcao(int opcao)
    {
        if (opcao == 1)
        {
            cadastrarHeroi();
        }
        else if (opcao == 2)
        {
            selecionarEquipe();
        }
        else if (opcao == 3)
        {
            exibirEquipe();
        }
    }

    static void cadastrarHeroi()
    {
        quantidadeHerois++;

        string nome = receberNome();
        string poder = receberPoder();
        int pontos = receberPontos();

        salvarHeroi(nome, poder, pontos);
    }

    static string receberNome()
    {
        Console.Write("Digite o nome do herói: ");
        return Console.ReadLine();
    }

    static string receberPoder()
    {
        Console.Write("Digite o poder do herói: ");
        return Console.ReadLine();
    }

    static int receberPontos()
    {
        Console.Write("Digite a pontuação do herói: ");
        return int.Parse(Console.ReadLine());
    }

    static void salvarHeroi(string nome, string poder, int pontos)
    {
        if (quantidadeHerois == 1)
        {
            nome1 = nome;
            poder1 = poder;
            pontos1 = pontos;
        }
        else if (quantidadeHerois == 2)
        {
            nome2 = nome;
            poder2 = poder;
            pontos2 = pontos;
        }
        else if (quantidadeHerois == 3)
        {
            nome3 = nome;
            poder3 = poder;
            pontos3 = pontos;
        }
        else if (quantidadeHerois == 4)
        {
            nome4 = nome;
            poder4 = poder;
            pontos4 = pontos;
        }
        else if (quantidadeHerois == 5)
        {
            nome5 = nome;
            poder5 = poder;
            pontos5 = pontos;
        }
        else
        {
            Console.WriteLine("Limite de heróis atingido!");
        }
    }

    static void selecionarEquipe()
    {
        mostrarHerois();

        int heroi1 = escolherHeroi();
        int heroi2 = escolherHeroi();
        int heroi3 = escolherHeroi();

        adicionarEquipe(heroi1, 1);
        adicionarEquipe(heroi2, 2);
        adicionarEquipe(heroi3, 3);
    }

    static void mostrarHerois()
    {
        Console.WriteLine("\nHeróis cadastrados:");
        Console.WriteLine("1 - " + nome1);
        Console.WriteLine("2 - " + nome2);
        Console.WriteLine("3 - " + nome3);
        Console.WriteLine("4 - " + nome4);
        Console.WriteLine("5 - " + nome5);
    }

    static int escolherHeroi()
    {
        Console.Write("Escolha um herói: ");
        return int.Parse(Console.ReadLine());
    }

    static void adicionarEquipe(int escolha, int posicao)
    {
        string nome = "";
        string poder = "";
        int pontos = 0;

        buscarHeroi(escolha, ref nome, ref poder, ref pontos);

        if (posicao == 1)
        {
            equipe1 = nome;
            poderEquipe1 = poder;
            pontosEquipe1 = pontos;
        }
        else if (posicao == 2)
        {
            equipe2 = nome;
            poderEquipe2 = poder;
            pontosEquipe2 = pontos;
        }
        else
        {
            equipe3 = nome;
            poderEquipe3 = poder;
            pontosEquipe3 = pontos;
        }
    }

    static void buscarHeroi(int escolha, ref string nome, ref string poder, ref int pontos)
    {
        if (escolha == 1)
        {
            nome = nome1;
            poder = poder1;
            pontos = pontos1;
        }
        else if (escolha == 2)
        {
            nome = nome2;
            poder = poder2;
            pontos = pontos2;
        }
        else if (escolha == 3)
        {
            nome = nome3;
            poder = poder3;
            pontos = pontos3;
        }
        else if (escolha == 4)
        {
            nome = nome4;
            poder = poder4;
            pontos = pontos4;
        }
        else if (escolha == 5)
        {
            nome = nome5;
            poder = poder5;
            pontos = pontos5;
        }
    }

    static void exibirEquipe()
    {
        Console.WriteLine("\nEquipe selecionada:");
        Console.WriteLine(equipe1 + " - " + poderEquipe1 + " - " + pontosEquipe1);
        Console.WriteLine(equipe2 + " - " + poderEquipe2 + " - " + pontosEquipe2);
        Console.WriteLine(equipe3 + " - " + poderEquipe3 + " - " + pontosEquipe3);

        Console.WriteLine("Pontuação total: " + calcularPontuacaoTotal());
    }

    static int calcularPontuacaoTotal()
    {
        return pontosEquipe1 + pontosEquipe2 + pontosEquipe3;
    }
}
