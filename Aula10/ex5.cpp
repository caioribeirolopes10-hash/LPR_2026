#include <iostream>
#include <string>
class produto {
    std::string nome;
    double preco;
};
class pedido {
    produto p;
    int quantidade;
};