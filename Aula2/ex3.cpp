#include <iostream>
using namespace std;

int main() {
    int numero, horas;
    float valorHora, salario;

    cout << "Digite o numero do funcionario: ";
    cin >> numero;

    cout << "Digite a quantidade de horas trabalhadas: ";
    cin >> horas;

    cout << "Digite o valor da hora: ";
    cin >> valorHora;

    salario = horas * valorHora;

    cout << "Numero do funcionario: " << numero << endl;
    cout << "Salario: R$ " << salario << endl;

    return 0;
}