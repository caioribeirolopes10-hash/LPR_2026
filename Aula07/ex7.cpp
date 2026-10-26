#include <iostream>

int main() 
{
    int A[3][3];
    int B[3][3];
    int C[3][3];

    std::cout << "Digite os valores da matriz A:\n";

    for (int i = 0; i < 3; i++) 
    {
        for (int j = 0; j < 3; j++) 
        {
            std::cout << "A[" << i << "," << j << "]: ";
            std::cin >> A[i][j];
        }
    }

    std::cout << "\nDigite os valores da matriz B:\n";

    for (int i = 0; i < 3; i++) 
    {
        for (int j = 0; j < 3; j++) 
        {
            std::cout << "B[" << i << "," << j << "]: ";
            std::cin >> B[i][j];
        }
    }

  
    for (int i = 0; i < 3; i++) 
    {
        for (int j = 0; j < 3; j++) 
        {
            C[i][j] = 0;

            for (int k = 0; k < 3; k++) 
            {
                C[i][j] += A[i][k] * B[k][j];
            }
        }
    }

    std::cout << "\nMatriz Resultado:\n";

    for (int i = 0; i < 3; i++) 
    {
        for (int j = 0; j < 3; j++) 
        {
            std::cout << C[i][j] << "\t";
        }

        std::cout << "\n";
    }

    return 0;
}