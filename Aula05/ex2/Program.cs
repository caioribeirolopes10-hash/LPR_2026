using System;

class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 100);

        int chute;
        int tentativas = 0;

        do
        {
            Console.Write("Digite um numero de 1 a 100: ");
            chute = int.Parse(Console.ReadLine());

            tentativas++;

            if (chute > valorInteiro)
            {
                Console.WriteLine("Chutou alto.");
            }
            else if (chute < valorInteiro)
            {
                Console.WriteLine("Chutou baixo.");
            }
            else
            {
                Console.WriteLine("Acertou!");
            }

        } while (chute != valorInteiro);

        Console.WriteLine("Voce acertou em " + tentativas + " tentativas.");
    }
}