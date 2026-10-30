#include <iostream>
#include <string>
#include <list>
using namespace std;    
class reservacao {
public: 
    string nome;
    int numeroReservas;

};
class cliente {
public:
    string nome;
    reservacao r;
    list<reservacao> reservas;

    void fazerReservacao(string nome, int numeroReservas) {
        r.nome = nome;
        r.numeroReservas = numeroReservas;
    }

    void mostrarReservacao() {
        cout << "Cliente: " << nome << endl;
        cout << "Reserva: " << r.nome << ", Número de Reservas: " << r.numeroReservas << endl;
    }
};