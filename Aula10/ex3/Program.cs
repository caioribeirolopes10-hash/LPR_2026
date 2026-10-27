using System;
class aluno
{
   public int matricula;
    public string nome;
    public double notap1;
    public double notap2;
    public double trabalho;
    static void Main(string[] args)
    {
        aluno a1 = new aluno();
        Console.WriteLine("Digite a matrícula do aluno: ");
        a1.matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do aluno: ");
        a1.nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota do aluno: ");
        a1.notap1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno: ");
        a1.notap2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do trabalho do aluno: ");
        a1.trabalho = double.Parse(Console.ReadLine());
        a1.peso();
    }

        public double peso()
        {
            double peso = (notap1 * 2.5) + (notap2 * 2.5) + (trabalho * 2.0) / 3;
            if (peso >= 60)
            {
                Console.WriteLine("A média ponderada do aluno é: " + peso + " - O aluno está aprovado!");
            }
            else
            {
                Console.WriteLine("A média ponderada do aluno é: " + peso + " - O aluno está reprovado!");
            }
            return peso;
        }

}



    


