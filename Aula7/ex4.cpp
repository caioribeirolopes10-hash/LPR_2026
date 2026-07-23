#include <iostream>
#include <string>

using namespace std;

string ClassificarAluno(int nota)
{
    if (nota >= 70)
    {
        return "Aprovado";
    }
    else if (nota >= 50)
    {
        return "Recuperacao";
    }
    else
    {
        return "Reprovado";
    }
}

int main()
{
    string nomes[10];
    int notas[10];

    int aprovados = 0;
    int recuperacao = 0;
    int reprovados = 0;
    int soma = 0;

    for (int i = 0; i < 10; i++)
    {
        cout << "Nome do aluno: ";
        cin >> nomes[i];

        cout << "Nota: ";
        cin >> notas[i];

        soma += notas[i];
    }

    cout << "\nRELATORIO\n\n";

    for (int i = 0; i < 10; i++)
    {
        string situacao = ClassificarAluno(notas[i]);

        cout << nomes[i] << " - " << notas[i] << " - " << situacao << endl;

        if (situacao == "Aprovado")
        {
            aprovados++;
        }
        else if (situacao == "Recuperacao")
        {
            recuperacao++;
        }
        else
        {
            reprovados++;
        }
    }

    float media = (float)soma / 10;

    cout << "\nAprovados: " << aprovados << endl;
    cout << "Recuperacao: " << recuperacao << endl;
    cout << "Reprovados: " << reprovados << endl;
    cout << "Media da turma: " << media << endl;

    return 0;
}