#include <iostream>
#include <vector>
using namespace std;

class Livro {
private:
    string titulo;
    string autor;
    int ano;
public:
    Livro(string t, string a, int an) {
        titulo = t;
        autor = a;
        ano = an;
    }
    string getTitulo() {
        return titulo;
    }
    string getAutor() {
        return autor;
    }
    int getAno() {
        return ano;
    }

    void setTitulo(string t) {
        titulo = t;
    }
    void setAutor(string a) {
        autor = a;
    }
    void setAno(int an) {
        ano = an;
    }
};

class Biblioteca {
private:
    vector<Livro> livros;
public:
    void AdicionarLivro(Livro l) {
        livros.push_back(l);
    }
    void ListarLivros() {
        for (int i = 0; i < livros.size(); i++) {
            cout << "\nTitulo: " << livros[i].getTitulo();
            cout << "\nAutor: " << livros[i].getAutor();
            cout << "\nAno: " << livros[i].getAno();
        }
    }
};

int main() {
    Biblioteca biblioteca;
    Livro l1("Dom Casmurro", "Machado de Assis", 1899);
    Livro l2("O Pequeno Principe", "Antoine de Saint-Exupery", 1943);
    biblioteca.AdicionarLivro(l1);
    biblioteca.AdicionarLivro(l2);
    biblioteca.ListarLivros();
    return 0;
}
