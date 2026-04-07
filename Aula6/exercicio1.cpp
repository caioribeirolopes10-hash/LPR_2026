#include <iostream> 
using namespace std;
int main()
{ 
int num , reverso = 0, resto ;

std :: cout << "Digite um número inteiro: " ; 
std :: cin >> num ;

while(num != 0)
{
        resto = num % 10;         
        reverso = reverso * 10 + resto; 
        num /= 10;
}
cout << "Numero invertido: " << reverso << endl;

return 0;
}