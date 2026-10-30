
#include <iostream>
#include <string>
#include <vector>
using namespace std;

class produto {
public:
    string nome;
    double preco;
};

class pedido {
public:
    vector<produto> produtos;
    vector<int> quantidades;

    void adicionarProduto(produto p, int quantidade) {
        produtos.push_back(p);
        quantidades.push_back(quantidade);
    }

    double total() {
        double soma = 0;

        for (int i = 0; i < produtos.size(); i++) {
            soma += produtos[i].preco * quantidades[i];
        }

        return soma;
    }
};

int main() {
    produto p1;
    p1.nome = "Mouse";
    p1.preco = 50.0;

    produto p2;
    p2.nome = "Teclado";
    p2.preco = 120.0;

    pedido meuPedido;

    meuPedido.adicionarProduto(p1, 2);
    meuPedido.adicionarProduto(p2, 1);

    cout << "Total do pedido: R$ " << meuPedido.total() << endl;

    return 0;
}
