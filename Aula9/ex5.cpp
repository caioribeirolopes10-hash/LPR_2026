#include <iostream>
#include <map>

using namespace std;

int main()
{
    map<string, string> jogos;
    string nome, genero;

    for (int i = 0; i < 5; i++)
    {
        cout << "Nome do jogo: ";
        cin >> nome;

        cout << "Genero: ";
        cin >> genero;

        jogos[nome] = genero;

        cout << endl;
    }

    cout << "Digite o nome do jogo que deseja pesquisar: ";
    cin >> nome;

    if (jogos.find(nome) != jogos.end())
    {
        cout << "Genero: " << jogos[nome] << endl;
    }
    else
    {
        cout << "Jogo nao cadastrado." << endl;
    }

    return 0;
}