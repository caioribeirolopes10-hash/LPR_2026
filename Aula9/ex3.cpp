#include <iostream>
#include <list>
#include <cstdlib>
#include <ctime>
using namespace std;

int main(){

   list<int> numeros;

    srand(time(NULL));

    for (int i = 0; i < 100; i++) {
        numeros.push_back(rand() % 1000);
    }
     numeros.sort();

     numeros.remove_if([](int x) {
    return x % 2 == 0;
});

 for (int numero = numero ) {

 }

    for (int numero : numeros) {
        cout << numero << " ";
    }

    return 0;

}