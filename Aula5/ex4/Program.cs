using System;

class Program
{
    static void Main()
    {
        int numero;
        int quadrado;
        int soma = 0;

        Console.Write("Digite um numero: ");
        numero = int.Parse(Console.ReadLine());

        quadrado = numero * numero;

        while (quadrado > 0)
        {
            soma = soma + (quadrado % 10);
            quadrado = quadrado / 10;
        }

        Console.WriteLine("A soma dos digitos e: " + soma);
    }
}
