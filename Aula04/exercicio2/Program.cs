using System;

class Program
{
    static void Main()
    {
        int A, B;

        Console.Write("Digite o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
