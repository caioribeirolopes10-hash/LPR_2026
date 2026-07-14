#include <iostream>
using namespace std;

int main() {
    int codigo1, codigo2;
    int quantidade1, quantidade2;
    float valor1, valor2, total;

    cout << "Digite o codigo da peca 1: ";
    cin >> codigo1;

    cout << "Digite a quantidade da peca 1: ";
    cin >> quantidade1;

    cout << "Digite o valor da peca 1: ";
    cin >> valor1;

    cout << "Digite o codigo da peca 2: ";
    cin >> codigo2;

    cout << "Digite a quantidade da peca 2: ";
    cin >> quantidade2;

    cout << "Digite o valor da peca 2: ";
    cin >> valor2;

    total = (quantidade1 * valor1) + (quantidade2 * valor2);

    cout << "Valor a pagar: R$ " << total << endl;

    return 0;
}