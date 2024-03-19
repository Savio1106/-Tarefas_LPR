/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <iostream>
#include <string>
using namespace std;
int main() {
    int numero;
    int divisor;

    cout << "Digite um numero : ";
    cin >> numero;

    cout << "Digite outro numero : ";
    cin >> divisor;

    int resto = numero % divisor;

    if (resto == 0) { 
        cout << "São múltiplos." << endl;
    } else {
        cout << "Não são múltiplos." << endl;
    }

    return 0;
}