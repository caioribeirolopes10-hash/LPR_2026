#include <iostream> 
using namespace std;
void funcao1()
{

    int i = 0;
    int acumulador = 0;
    int quantidade;
    int pares = 0;
    std::cout << "Quantos numeros serao digitados?" << std::endl;
    std::cin >> quantidade;
    while (i < quantidade) 
    {
        std::cout << "Digite o " << (i+1) << "º numero: " << std::endl;
        int numero;
        std::cin >> numero;
     if (numero % 2 == 0) 
     {
        acumulador += numero;
        pares++;
     }
    i++;
    }
    if (pares > 0) 
    {
     double media = (double)acumulador / pares;
     std::cout << "A media dos pares e: " << media << std::endl;
    } else 
    {
        std::cout << "Nenhum numero par foi digitado." << std::endl;
    }
}
  void funcao2(){

 int soma = 0;       

    for (int i = 50; i <= 500; i++) 
    {
        if (i % 2 != 0 && i % 3 == 0)
        {
            soma += i;
        }
    }

    cout << "A soma dos numeros eh: " << soma << endl;

    return 0;
}

void funcao3 ()
{
   
    {
        int numero ; 
        int quadrado = numero * numero;
        int soma = 0;
        int temp = quadrado;
        
    std::cout << "Digite um número" << std::endl;
    std::cin >> numero;

        while (temp > 0)
        {
            soma += temp % 10; 
            temp /= 10;        
        }

        std::cout << "Quadrado:" << std::endl;
        std::cin >> quadrado;
        std::cout << "Soma dos dígitos:" << std::endl;
        std::cin >> soma;
    }
}
int main()
