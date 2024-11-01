using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno aluno = new Aluno();

           
            Console.Write("Digite a matrícula do aluno: ");
            aluno.Matricula = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a nota da Prova 1: ");
            aluno.NotaProva1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da Prova 2: ");
            aluno.NotaProva2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do Trabalho: ");
            aluno.NotaTrabalho = double.Parse(Console.ReadLine());

          
            double media = aluno.Media();
            Console.WriteLine($"A média final do aluno {aluno.Nome} é: {media:F2}");

            double notaFinal = aluno.Final();
            if (notaFinal > 0)
            {
                Console.WriteLine($"O aluno {aluno.Nome} precisa de {notaFinal:F2} na prova final.");
            }
            else
            {
                Console.WriteLine($"O aluno {aluno.Nome} não precisa fazer a prova final.");
            }
        }
    }
}
