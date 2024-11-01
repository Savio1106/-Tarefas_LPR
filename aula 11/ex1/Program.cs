using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + retangulo.calcArea().ToString("F2"));
            Console.WriteLine("Perímetro = " + retangulo.calcPerimetro().ToString("F2"));
        }
    }
}
