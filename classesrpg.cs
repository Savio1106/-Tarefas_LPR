/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int escolha;
    Console.WriteLine("Faça uma escolha, digite um numero: \n1 = Guerreiro \n2 = Mago \n3 = Arqueiro"); 
    escolha = Convert.ToInt32(Console.ReadLine());
    
    switch (escolha) {
        case 1:
            Console.WriteLine("Guerreira = Ataque Pesado, Defesa total"); 
            break;
        case 2:
            Console.WriteLine("Mago Bola de Fogo, Escudo de Gelo");
            break;
        case 3:
            Console.WriteLine("Arqueira Flecha Precisa, Disparo Triplo");
            break;
        default:
            Console.WriteLine("Sua escolha é inválida, reinicie o programa e faça uma escolha certa.");
            break;
    }
  }
}