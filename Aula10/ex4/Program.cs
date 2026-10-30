
using System;

public class jogo
{
    string personagem;
    int vida;
    int ataque;
    int defesa;

    static void Main(string[] args)
    {
        jogo j1 = new jogo();

        Console.WriteLine("Digite o nome do personagem: ");
        j1.personagem = Console.ReadLine();

        Console.WriteLine("Digite a vida do personagem: ");
        j1.vida = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ataque do personagem: ");
        j1.ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a defesa do personagem: ");
        j1.defesa = int.Parse(Console.ReadLine());

        jogo j2 = new jogo();

        Console.WriteLine("Digite o nome do adversário: ");
        j2.personagem = Console.ReadLine();

        Console.WriteLine("Digite a vida do adversário: ");
        j2.vida = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ataque do adversário: ");
        j2.ataque = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a defesa do adversário: ");
        j2.defesa = int.Parse(Console.ReadLine());

        j1.batalha(j2);
    }

    public void batalha(jogo j2)
    {
        int dano = ataque - j2.defesa;

        if (dano > 0)
        {
            j2.vida -= dano;

            Console.WriteLine(personagem + " causou "
                + dano + " de dano em " + j2.personagem);
        }
        else
        {
            Console.WriteLine(personagem
                + " não conseguiu causar dano em "
                + j2.personagem);
        }

        if (j2.vida <= 0)
        {
            Console.WriteLine(j2.personagem + " foi derrotado!");
        }
        else
        {
            Console.WriteLine(j2.personagem
                + " ainda tem " + j2.vida + " de vida.");
        }
    }
}
