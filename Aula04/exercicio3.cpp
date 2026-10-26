#include <iostream>
using namespace std;

int main() {
    int classe;

    cout << "Escolha uma classe:" << endl;
    cout << "1 - Guerreiro" << endl;
    cout << "2 - Mago" << endl;
    cout << "3 - Arqueiro" << endl;
    cout << "Digite a opcao: ";
    cin >> classe;

    switch (classe) {
        case 1:
            cout << "Classe: Guerreiro" << endl;
            cout << "Habilidades: Ataque Pesado e Escudo Defensivo." << endl;
            break;

        case 2:
            cout << "Classe: Mago" << endl;
            cout << "Habilidades: Bola de Fogo e Raio de Gelo." << endl;
            break;

        case 3:
            cout << "Classe: Arqueiro" << endl;
            cout << "Habilidades: Flecha Precisa e Chuva de Flechas." << endl;
            break;

        default:
            cout << "Opcao invalida." << endl;
    }

    return 0;
}