using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário bruto do funcionário:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            funcionario.MostrarDados();

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados:");
            funcionario.MostrarDados();
        }
    }
}
