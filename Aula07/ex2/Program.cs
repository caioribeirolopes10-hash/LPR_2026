using System.Data.Common;
int [] num = new int[10];
int posicao = 0;
Console.WriteLine("Digite dez números para o vetor");
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"Número ({i + 1}): "); 
    num[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n--- Busca por Posição ---");
Console.Write("Digite a posição que deseja buscar (de 1 a 10): ");
int pos = int.Parse(Console.ReadLine());

if (posicao >= 1 && posicao <= 10)
{
    int indice = posicao - 1; 
    Console.WriteLine($"Posição {posicao}: {num[indice]}");
}
else
{
    Console.WriteLine("Posição inválida! Digite um número entre 1 e 10.");
}

