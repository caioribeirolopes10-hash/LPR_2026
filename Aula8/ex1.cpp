#include <iostream>

using namespace std;

struct Filme
{
    string titulo;
    string diretor;
    int anoLancamento;
    int duracaoMinutos;
};

int main()
{
    Filme filmes[3];

    for (int i = 0; i < 3; i++)
    {
        cout << "Filme " << i + 1 << endl;

        cout << "Titulo: ";
        cin >> filmes[i].titulo;

        cout << "Diretor: ";
        cin >> filmes[i].diretor;

        cout << "Ano de Lancamento: ";
        cin >> filmes[i].anoLancamento;

        cout << "Duracao (minutos): ";
        cin >> filmes[i].duracaoMinutos;

        cout << endl;
    }

    int maisAntigo = 0;

    for (int i = 1; i < 3; i++)
    {
        if (filmes[i].anoLancamento < filmes[maisAntigo].anoLancamento)
        {
            maisAntigo = i;
        }
    }

    cout << "\nFilmes cadastrados:\n\n";

    for (int i = 0; i < 3; i++)
    {
        cout << "Titulo: " << filmes[i].titulo << endl;
        cout << "Diretor: " << filmes[i].diretor << endl;
        cout << "Ano: " << filmes[i].anoLancamento << endl;
        cout << "Duracao: " << filmes[i].duracaoMinutos << " minutos" << endl;
        cout << endl;
    }

    cout << "Filme mais antigo:" << endl;
    cout << "Titulo: " << filmes[maisAntigo].titulo << endl;
    cout << "Ano: " << filmes[maisAntigo].anoLancamento << endl;

    return 0;
}