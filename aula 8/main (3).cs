using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; // Declara um vetor para armazenar os 10 números inteiros
        Console.WriteLine("Digite 10 números inteiros:"); // Solicita ao usuário que digite 10 números inteiros

        // Loop para ler os 10 números inteiros
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine()); // Lê cada número e armazena no vetor 'numeros'
        }

        Console.WriteLine("Digite o número que deseja pesquisar:"); // Solicita ao usuário que digite um número para pesquisa
        int numeroParaPesquisar = int.Parse(Console.ReadLine()); // Lê o número que será pesquisado

        int ocorrencias = 0; // Inicializa o contador de ocorrências
        Console.WriteLine($"O número {numeroParaPesquisar} aparece nas seguintes posições:");

        // Loop para pesquisar o número no vetor
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] == numeroParaPesquisar) // Verifica se o número atual é igual ao número pesquisado
            {
                Console.WriteLine(i); // Exibe a posição (índice) onde o número foi encontrado
                ocorrencias++; // Incrementa o contador de ocorrências
            }
        }

        // Exibe o total de ocorrências encontradas
        Console.WriteLine($"Total de ocorrências: {ocorrencias}");

        // Verifica se o número não foi encontrado
        if (ocorrencias == 0)
        {
            Console.WriteLine("O número não foi encontrado no vetor."); // Informa que o número não foi encontrado
        }
    }
}
