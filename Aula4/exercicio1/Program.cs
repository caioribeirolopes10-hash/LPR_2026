using System.Globalization;

Console.WriteLine("Digite um número e direi se ele é par ou ímpar");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("Seu número é par");
}
else
{
    Console.WriteLine("Seu númro é ímpar");
} 
