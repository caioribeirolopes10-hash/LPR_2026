using System.Data.Common;

int [] num = new int[10];
int [] par = new int[10];
int [] imp = new int[10];
int ehpar = 0; 
int ehimp = 0;
Console.WriteLine("Dgite 10 números :");
for (int i = 0; i <num.Length; i++)
{
    Console.Write("Número " + (i + 1) + ": ");
    num[i] = int.Parse((Console.ReadLine()));
}
for (int j = 0; j < num.Length; j++)
{
    if (num[j] % 2 == 0)
    {
        if (ehpar < par.Length)
        {
            par[ehpar] = num[j];
            ehpar++;
        }
    }
    else
    {
        if (ehimp < imp.Length)
        {
            imp[ehimp]= num[j];
            ehimp++;
        }
    }
}
Array.Sort(par, 0, ehpar);
Array.Sort(imp, 0, ehimp);
Console.WriteLine("\nNúmeros pares:");
for (int i = 0; i < ehpar; i++)
{
    Console.Write(par[i] + " ");
}
Console.WriteLine("\nNúmeros ímpares:");
for (int i = 0; i < ehimp; i++)
{
    Console.Write(imp[i] + " ");
}