using System;
class aluno
{
   public int matricula;
    public string nome;
    public double nota1;
    public double nota2;
    public double trabalho;
    static void Main(string[] args)
    {
        aluno a1 = new aluno();
        Console.WriteLine("Digite a matrícula do aluno: ");
        a1.matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do aluno: ");
        a1.nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota do aluno: ");
        a1.nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno: ");
        a1.nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do trabalho do aluno: ");
        a1.trabalho = double.Parse(Console.ReadLine());
    }

        public double peso()
        {
            double media = (nota1 * 0.3) + (nota2 * 0.3) + (trabalho * 0.4);
            Console.WriteLine("Média ponderada: " + media);
            return media;
        }

}



    


