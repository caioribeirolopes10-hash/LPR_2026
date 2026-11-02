
#include <iostream>
#include <vector>
using namespace std;

class Aluno;
class Turma;

class Matricula {
private:
    Aluno* aluno;
    Turma* turma;
    string data;

public:
    Matricula(Aluno* a, Turma* t, string d) {
        aluno = a;
        turma = t;
        data = d;
    }

    Aluno* getAluno() {
        return aluno;
    }

    Turma* getTurma() {
        return turma;
    }

    string getData() {
        return data;
    }
};

class Aluno {
private:
    string nome;
    vector<Matricula*> matriculas;

public:
    Aluno(string n) {
        nome = n;
    }

    string getNome() {
        return nome;
    }

    void AdicionarMatricula(Matricula* m) {
        matriculas.push_back(m);
    }

    bool JaMatriculado(Turma* t);
};

class Turma {
private:
    string nome;
    vector<Matricula*> matriculas;

public:
    Turma(string n) {
        nome = n;
    }

    string getNome() {
        return nome;
    }

    void AdicionarMatricula(Matricula* m) {
        matriculas.push_back(m);
    }

    void ListarAlunos() {
        for (int i = 0; i < matriculas.size(); i++) {
            cout << matriculas[i]->getAluno()->getNome() << endl;
        }
    }
};

bool Aluno::JaMatriculado(Turma* t) {
    for (int i = 0; i < matriculas.size(); i++) {
        if (matriculas[i]->getTurma() == t) {
            return true;
        }
    }
    return false;
}

int main() {
    Aluno a1("Caio");
    Aluno a2("Joao");
    Turma t1("Eletronica");
    Turma t2("Informatica");

    if (!a1.JaMatriculado(&t1)) {
        Matricula* m1 = new Matricula(&a1, &t1, "02/11/2026");
        a1.AdicionarMatricula(m1);
        t1.AdicionarMatricula(m1);
    }

    if (!a2.JaMatriculado(&t1)) {
        Matricula* m2 = new Matricula(&a2, &t1, "02/11/2026");
        a2.AdicionarMatricula(m2);
        t1.AdicionarMatricula(m2);
    }

    if (!a1.JaMatriculado(&t2)) {
        Matricula* m3 = new Matricula(&a1, &t2, "02/11/2026");
        a1.AdicionarMatricula(m3);
        t2.AdicionarMatricula(m3);
    }

    cout << "Alunos da turma " << t1.getNome() << ":" << endl;
    t1.ListarAlunos();

    cout << "\nAlunos da turma " << t2.getNome() << ":" << endl;
    t2.ListarAlunos();

    return 0;
}
