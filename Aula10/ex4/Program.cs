using System;
public class jogo
{
    string personagem;
    int vida;
    int ataque;
    int defesa;
    string adversario;
    int vidaAdversario;
    int ataqueAdversario;
    int defesaAdversario;
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
        j2.adversario = Console.ReadLine();
        Console.WriteLine("Digite a vida do adversário: ");
        j2.vidaAdversario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ataque do adversário: ");
        j2.ataqueAdversario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a defesa do adversário: ");
        j2.defesaAdversario = int.Parse(Console.ReadLine());
        j1.batalha(j2);

    }

    public batalha(jogo j1, jogo j2)
    {
        int dano = j1.ataque - j2.defesaAdversario;
        if (dano > 0)
        {
            j2.vidaAdversario -= dano;
            Console.WriteLine(j1.personagem + " causou " + dano + " de dano em " + j2.adversario);
        }
        else
        {
            Console.WriteLine(j1.personagem + " não conseguiu causar dano em " + j2.adversario);
        }

        if (j2.vidaAdversario <= 0)
        {
            Console.WriteLine(j2.adversario + " foi derrotado!");
        }
        else
        {
            Console.WriteLine(j2.adversario + " ainda tem " + j2.vidaAdversario + " de vida.");
        }
    }
}