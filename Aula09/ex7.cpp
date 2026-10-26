#include <iostream>
#include <map>
#include <vector>

using namespace std;

int main()
{
    map<string, int> cidades;
    string nome;
    int populacao, x;

    cout << "Quantas cidades deseja cadastrar? ";
    cin >> x;

    for (int i = 0; i < x; i++)
    {
        cout << "Nome da cidade: ";
        cin >> nome;

        cout << "Populacao: ";
        cin >> populacao;

        cidades[nome] = populacao;
    }

    int soma = 0;

    for (auto cidade : cidades)
    {
        soma += cidade.second;
    }

    float media = (float)soma / cidades.size();

    cout << "\nCidades com populacao acima da media:\n";

    for (auto cidade : cidades)
    {
        if (cidade.second > media)
        {
            cout << cidade.first << " - " << cidade.second << endl;
        }
    }

    string maisPopulosa, menosPopulosa;
    int maior = -1;
    int menor = 1000000000;

    for (auto cidade : cidades)
    {
        if (cidade.second > maior)
        {
            maior = cidade.second;
            maisPopulosa = cidade.first;
        }

        if (cidade.second < menor)
        {
            menor = cidade.second;
            menosPopulosa = cidade.first;
        }
    }

    cout << "\nCidade mais populosa: " << maisPopulosa << endl;
    cout << "Cidade menos populosa: " << menosPopulosa << endl;

    int y;

    cout << "\nDigite a populacao que deseja remover: ";
    cin >> y;

    vector<string> remover;

    for (auto cidade : cidades)
    {
        if (cidade.second == y)
        {
            remover.push_back(cidade.first);
        }
    }

    for (int i = 0; i < remover.size(); i++)
    {
        cidades.erase(remover[i]);
    }

    cout << "\nDicionario atualizado:\n";

    for (auto cidade : cidades)
    {
        cout << cidade.first << " - " << cidade.second << endl;
    }

    return 0;
}