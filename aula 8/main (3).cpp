#include <iostream>
#include <string>

using namespace std;

int main() {
    const int NUM_CIDADES = 4;
    string cidades[NUM_CIDADES] = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};
    int distancias[NUM_CIDADES][NUM_CIDADES] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    while (true) {
        string origem, destino;
        cout << "Informe a cidade de origem (Vitória, Belo Horizonte, Rio de Janeiro, São Paulo): ";
        getline(cin, origem);
        cout << "Informe a cidade de destino (Vitória, Belo Horizonte, Rio de Janeiro, São Paulo): ";
        getline(cin, destino);

        if (origem == destino) {
            cout << "Origem e destino são as mesmas. Encerrando o programa." << endl;
            break;
        }

        int indexOrigem = -1, indexDestino = -1;
        for (int i = 0; i < NUM_CIDADES; i++) {
            if (cidades[i] == origem) {
                indexOrigem = i;
            }
            if (cidades[i] == destino) {
                indexDestino = i;
            }
        }

        if (indexOrigem == -1 || indexDestino == -1) {
            cout << "Uma ou ambas as cidades são inválidas. Tente novamente." << endl;
        } else {
            cout << "A distância entre " << origem << " e " << destino << " é " << distancias[indexOrigem][indexDestino] << " km." << endl;
        }
    }

    return 0;
}
