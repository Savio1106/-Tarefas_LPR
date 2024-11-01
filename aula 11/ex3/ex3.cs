using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{

        static void Main(string[] args)
        {
          public class Aluno
        {

            public int Matricula { get; set; }
            public string Nome { get; set; }
            public double NotaProva1 { get; set; }
            public double NotaProva2 { get; set; }
            public double NotaTrabalho { get; set; }


            public double Media()
            {

                return (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7.0;
            }


            public double Final()
            {
                double mediaAtual = Media();
                if (mediaAtual >= 5.0)
                {
                    return 0;
                }
                else
                {

                    return (5.0 * 7 - (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2)) / 2.5;
                }
            }
        }

    }
}


