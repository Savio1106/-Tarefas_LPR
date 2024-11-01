using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Funcionario
    {
        public string Nome; 
        public double SalarioBruto; 
        public double Imposto; 

   
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

    
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

     
        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salário Líquido: " + SalarioLiquido().ToString("F2"));
        }
    }
}
