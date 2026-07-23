#include <iostream>

using namespace std;

struct Chamado
{
    int numero;
    string solicitante;
    string setor;
    int prioridade;
    string status;
    string descricao;
};

Chamado chamados[10];
int total = 0;

string classificarPrioridade(int prioridade)
{
    if (prioridade == 1)
        return "Baixa";
    else if (prioridade == 2)
        return "Media";
    else
        return "Alta";
}

void cadastrarChamado()
{
    if (total == 10)
    {
        cout << "Limite de chamados atingido.\n";
        return;
    }

    cout << "Numero: ";
    cin >> chamados[total].numero;

    cout << "Solicitante: ";
    cin >> chamados[total].solicitante;

    cout << "Setor: ";
    cin >> chamados[total].setor;

    cout << "Prioridade (1-Baixa, 2-Media, 3-Alta): ";
    cin >> chamados[total].prioridade;

    cout << "Descricao: ";
    cin >> chamados[total].descricao;

    chamados[total].status = "Aberto";

    total++;

    cout << "Chamado cadastrado!\n";
}

void listarChamados()
{
    for (int i = 0; i < total; i++)
    {
        cout << "\nChamado " << i + 1 << endl;
        cout << "Numero: " << chamados[i].numero << endl;
        cout << "Solicitante: " << chamados[i].solicitante << endl;
        cout << "Setor: " << chamados[i].setor << endl;
        cout << "Prioridade: " << classificarPrioridade(chamados[i].prioridade) << endl;
        cout << "Status: " << chamados[i].status << endl;
        cout << "Descricao: " << chamados[i].descricao << endl;
    }
}

void atualizarStatus()
{
    int numero;
    int opcao;

    cout << "Digite o numero do chamado: ";
    cin >> numero;

    for (int i = 0; i < total; i++)
    {
        if (chamados[i].numero == numero)
        {
            cout << "1 - Em andamento\n";
            cout << "2 - Resolvido\n";
            cout << "3 - Cancelado\n";
            cout << "Opcao: ";
            cin >> opcao;

            if (opcao == 1)
                chamados[i].status = "Em andamento";
            else if (opcao == 2)
                chamados[i].status = "Resolvido";
            else if (opcao == 3)
                chamados[i].status = "Cancelado";

            cout << "Status atualizado!\n";
            return;
        }
    }

    cout << "Chamado nao encontrado.\n";
}

void estatisticas()
{
    int aberto = 0;
    int andamento = 0;
    int resolvido = 0;
    int cancelado = 0;

    for (int i = 0; i < total; i++)
    {
        if (chamados[i].status == "Aberto")
            aberto++;
        else if (chamados[i].status == "Em andamento")
            andamento++;
        else if (chamados[i].status == "Resolvido")
            resolvido++;
        else if (chamados[i].status == "Cancelado")
            cancelado++;
    }

    cout << "\nEstatisticas\n";
    cout << "Abertos: " << aberto << endl;
    cout << "Em andamento: " << andamento << endl;
    cout << "Resolvidos: " << resolvido << endl;
    cout << "Cancelados: " << cancelado << endl;
}

int main()
{
    int opcao;

    do
    {
        cout << "\n1 - Cadastrar chamado\n";
        cout << "2 - Listar chamados\n";
        cout << "3 - Atualizar status\n";
        cout << "4 - Estatisticas\n";
        cout << "0 - Sair\n";
        cout << "Opcao: ";
        cin >> opcao;

        if (opcao == 1)
            cadastrarChamado();
        else if (opcao == 2)
            listarChamados();
        else if (opcao == 3)
            atualizarStatus();
        else if (opcao == 4)
            estatisticas();

    } while (opcao != 0);

    return 0;
}