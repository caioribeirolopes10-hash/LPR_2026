using System;
class funcionario
{
    public string nome;
    public double salariobruto;
    public double imposto;

    public string informacoes()
    {   
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário bruto: " + salariobruto);
        Console.WriteLine("Imposto: " + imposto);
        return nome;
    }

    public double reajuste()
    {
        double salarioLiquido = (salariobruto - imposto);
        double reajuste;
        if (salarioLiquido <= 2000)
        {
            reajuste = (salarioLiquido * 1.10);
        }
        else if (salarioLiquido >= 2000 && salarioLiquido <= 3000)
        {
            reajuste = (salarioLiquido * 1.15);
        }
        else
        {
            reajuste = (salarioLiquido * 1.20);
        }
         Console.WriteLine("Salário reajustado: " + reajuste);
        return reajuste;
    }
   static void Main(string[] args)
    {
    
        funcionario f1 = new funcionario();
        Console.WriteLine("Digite o nome do funcionário: ");
        f1.nome = Console.ReadLine();
        Console.WriteLine("Digite o salário bruto do funcionário: ");
        f1.salariobruto = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o imposto do funcionário: ");
        f1.imposto = double.Parse(Console.ReadLine());
        f1.informacoes();
        f1.reajuste();
    
    }
}