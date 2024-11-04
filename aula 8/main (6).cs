using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3];

        // Leitura da matriz A
        Console.WriteLine("Digite os elementos da matriz A (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Leitura da matriz B
        Console.WriteLine("Digite os elementos da matriz B (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i},{j}] = ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Multiplicação das matrizes A e B
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Impressão da matriz resultante C
        Console.WriteLine("A matriz resultante C (A*B) é:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
