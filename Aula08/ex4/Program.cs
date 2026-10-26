using System;

struct Heroi
{
    public string heroi;
    public string poder;
    public int pontuacaoPoder;
}

class Program
{
    static Heroi[] escolherHeroi()
    {
        Heroi[] nHeroi = new Heroi[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nHerói {i + 1}:");

            Console.Write("Nome do herói: ");
            nHeroi[i].heroi = Console.ReadLine();

            Console.Write("Poder: ");
            nHeroi[i].poder = Console.ReadLine();

            Console.Write("Pontuação de poder: ");
            nHeroi[i].pontuacaoPoder = int.Parse(Console.ReadLine());
        }

        return nHeroi;
    }

    static void escolherEquipe(Heroi[] herois)
    {
        
        int quantidade = 0;

        if (quantidade < 1 || quantidade > 3)
        {
            Console.WriteLine("Quantidade inválida!");
            return;
        }

        Heroi[] equipe = new Heroi[quantidade];

        Console.WriteLine("\nHeróis disponíveis:");

        for (int i = 0; i < herois.Length; i++)
        {
            Console.WriteLine($"{i} - {herois[i].heroi}");
        }

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"\nEscolha o índice do herói {i + 1}: ");
            int indice = int.Parse(Console.ReadLine());

            equipe[i] = herois[indice];
        }

        Console.WriteLine("\nEquipe formada:");

        foreach (Heroi h in equipe)
        {
            Console.WriteLine($"{h.heroi} - {h.poder}");
        }
    }
    
   static void calcularPontuacaoTotal(Heroi[] equipe)
{
    int poderEquipe = equipe[0].pontuacaoPoder + equipe[1].pontuacaoPoder + equipe[2].pontuacaoPoder;
    Console.WriteLine("O poder total da equipe é: " + poderEquipe);
}

static void exibirEquipe(Heroi[] equipe)
{
    int pontuacaoTotal = 0;

    Console.WriteLine("\n=== EQUIPE ===");

    for (int i = 0; i < equipe.Length; i++)
    {
        Console.WriteLine($"Herói: {equipe[i].heroi}");
        Console.WriteLine($"Poder: {equipe[i].poder}");
        Console.WriteLine($"Pontuação: {equipe[i].pontuacaoPoder}");
        Console.WriteLine();

        pontuacaoTotal += equipe[i].pontuacaoPoder;
    }

    Console.WriteLine($"Pontuação total da equipe: {pontuacaoTotal}");
}
static void menuPrincipal()
{
    Heroi[] herois = null;
    Heroi[] equipe = null;

    int opcao = 0;

    while (opcao != 4)
    {
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("1 - Cadastrar heróis");
        Console.WriteLine("2 - Selecionar equipe");
        Console.WriteLine("3 - Exibir equipe");
        Console.WriteLine("4 - Sair");
        Console.Write("Escolha uma opção: ");

        int.TryParse(Console.ReadLine(), out opcao);

        if (opcao == 1)
        {
            herois = escolherHeroi();
        }
        else if (opcao == 2)
        {
            if (herois == null)
            {
                Console.WriteLine("Cadastre os heróis primeiro!");
            }
            else
            {
                escolherEquipe(herois);
            }
        }
        else if (opcao == 3)
        {
            if (equipe == null)
            {
                Console.WriteLine("Nenhuma equipe foi criada!");
            }
            else
            {
                exibirEquipe(equipe);
            }
        }
        else if (opcao == 4)
        {
            Console.WriteLine("Encerrando o programa...");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}
}
    

