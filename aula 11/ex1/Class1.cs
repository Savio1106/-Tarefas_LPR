using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        // Método para calcular a área
        public double calcArea()
        {
            return Altura * Largura;
        }

        // Método para calcular o perímetro
        public double calcPerimetro()
        {
            return 2 * (Altura + Largura);
        }
    }
}
