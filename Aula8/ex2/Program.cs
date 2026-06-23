using System;

struct Produto
{
    public string Nome;
    public int Codigo;
    public double Preco;
    public int Quantidade;
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];
        double estoque = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nProduto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            estoque += produtos[i].Preco * produtos[i].Quantidade;
        }

        Console.WriteLine($"\nValor total em estoque: R$ {estoque:F2}");
    }
}
