#include <iostream>
#include <string>
using namespace std;

struct Livro
{
    string titulo;
    string autor;
    int anop;
    int paginas;
    double preco;
};
static void Main (){
    Livro livros[3];

    for (int i = 0; i < 3; i++) {
        cin.ignore();

        cout << "\nLivro " << i + 1 << ":" << endl;

        cout << "Titulo: ";
        getline(cin, livros[i].titulo);

        cout << "Autor: ";
        getline(cin, livros[i].autor);

        cout << "Ano de Publicacao: ";
        cin >> livros[i].anop;

        cout << "Numero de Paginas: ";
        cin >> livros[i].paginas;

        cout << "Preco: ";
        cin >> livros[i].preco;
    }

    cout << "\n--- Dados dos Livros ---" << endl;

    for (int i = 0; i < 3; i++) {
        cout << "\nLivro " << i + 1 << endl;
        cout << "Titulo: " << livros[i].titulo << endl;
        cout << "Autor: " << livros[i].autor << endl;
        cout << "Ano de Publicacao: " << livros[i].anop << endl;
        cout << "Numero de Paginas: " << livros[i].paginas << endl;
        cout << "Preco: R$ " << livros[i].preco << endl;
    }

    return ;
};