#include <iostream> // Inclui a biblioteca padrão deentrada e saída entrada e saída
using namespace std; // Usa o namespace padrão

int main() {
    int numeros[10]; // Declara um vetor para armazenar os 10 números inteiros

    // Informa ao usuário que deve digitar 10 números inteiros
    cout << "Digite 10 números inteiros:" << endl;

    // Loop para ler os 10 números inteiros
    for (int i = 0; i < 10; i++) {
        cin >> numeros[i]; // Lê cada número e armazena no vetor 'numeros'
    }

    int pares[10]; // Declara um vetor para armazenar os números pares
    int impares[10]; // Declara um vetor para armazenar os números ímpares
    int contPares = 0; // Inicializa o contador de números pares
    int contImpares = 0; // Inicializa o contador de números ímpares

    // Loop para separar os números em pares e ímpares
    for (int i = 0; i < 10; i++) {
        // Verifica se o número é par
        if (numeros[i] % 2 == 0) {
            pares[contPares] = numeros[i]; // Armazena o número par no vetor 'pares'
            contPares++; // Incrementa o contador de números pares
        } else {
            // Caso contrário, o número é ímpar
            impares[contImpares] = numeros[i]; // Armazena o número ímpar no vetor 'impares'
            contImpares++; // Incrementa o contador de números ímpares
        }
    }

    // Exibição dos números pares
    cout << "PAR: "; // Informa ao usuário que a seguir serão exibidos os números pares
    for (int i = 0; i < contPares; i++) {
        cout << pares[i] << " "; // Exibe cada número par armazenado no vetor 'pares'
    }
    cout << endl; // Pula para a próxima linha após exibir todos os números pares

    // Exibição dos números ímpares
    cout << "ÍMPAR: "; // Informa ao usuário que a seguir serão exibidos os números ímpares
    for (int i = 0; i < contImpares; i++) {
        cout << impares[i] << " "; // Exibe cada número ímpar armazenado no vetor 'impares'
    }
    cout << endl; // Pula para a próxima linha após exibir todos os números ímpares

    return 0; // Retorna 0 para indicar que o programa terminou com sucesso
}