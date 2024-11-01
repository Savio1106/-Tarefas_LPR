#include <iostream>
#include <string>

struct Livro {
    std::string Titulo;
    std::string Autor;
    int AnoPublicacao;
    int NumPaginas;
    float Preco;
    int Quantidade;
};

int main() {
    Livro biblioteca[3];

    biblioteca[0] = {"Hamlet", "William Shakespeare", 1601, 160, 36.78, 10};
    biblioteca[1] = {"Romeu e Julieta", "William Shakespeare", 1595, 248, 29.90, 30};
    biblioteca[2] = {"Otelo", "William Shakespeare", 1603, 160, 40.00, 10};

    float media_paginas = 0;
    float total_preco = 0;

    for (int i = 0; i < 3; ++i) {
        total_preco += biblioteca[i].Preco;
        media_paginas += biblioteca[i].NumPaginas;
    }
    media_paginas /= 3;

    std::cout << "O valor total dos livros na biblioteca é: " << total_preco << std::endl;
    std::cout << "A média de páginas dos livros na biblioteca é: " << media_paginas << std::endl;

    return 0;
}
