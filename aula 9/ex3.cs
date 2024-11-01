using System;

namespace SistemaSelecaoHerois
{
    class Program
    {
        // Struct para armazenar informações de um herói
        struct Heroi
        {
            public string Nome;
            public string Poder;
            public int Pontuacao;
        }

        // Struct para armazenar a equipe de heróis e a pontuação total
        struct Equipe
        {
            public Heroi[] Herois;
            public int PontuacaoTotal;
        }

        // Array para armazenar até 5 heróis
        static Heroi[] herois = new Heroi[5];
        static int contadorHerois = 0; // Contador de heróis cadastrados
        static Equipe equipe; // Estrutura para armazenar a equipe selecionada

        static void Main(string[] args)
        {
            equipe.Herois = new Heroi[3]; // Inicializa o array de heróis da equipe
            equipe.PontuacaoTotal = 0; // Inicializa a pontuação total da equipe

            bool continuar = true;

            // Loop principal do programa que exibe o menu até o usuário decidir sair
            while (continuar)
            {
                continuar = menuPrincipal();
            }
        }

        static bool menuPrincipal()
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Cadastrar Herói");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    cadastrarHeroi();
                    break;
                case "2":
                    selecionarEquipe();
                    break;
                case "3":
                    exibirEquipe();
                    break;
                case "4":
                    return false; // Sair do programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            return true; // Continua no loop do menu
        }

        static void cadastrarHeroi()
        {
            if (contadorHerois >= 5)
            {
                Console.WriteLine("Não é possível cadastrar mais heróis. Limite atingido.");
                return;
            }

            Heroi novoHeroi;

            Console.Write("Digite o nome do herói: ");
            novoHeroi.Nome = Console.ReadLine();

            Console.Write("Digite o poder do herói: ");
            novoHeroi.Poder = Console.ReadLine();

            Console.Write("Digite a pontuação do herói: ");
            while (!int.TryParse(Console.ReadLine(), out novoHeroi.Pontuacao))
            {
                Console.WriteLine("Entrada inválida. Digite um número para a pontuação.");
                Console.Write("Digite a pontuação do herói: ");
            }

            herois[contadorHerois] = novoHeroi; // Armazena o herói no array
            contadorHerois++; // Incrementa o contador de heróis cadastrados

            Console.WriteLine("Herói cadastrado com sucesso!");
        }

        static void selecionarEquipe()
        {
            if (contadorHerois < 3)
            {
                Console.WriteLine("Cadastre pelo menos 3 heróis antes de selecionar uma equipe.");
                return;
            }

            Console.WriteLine("Selecione 3 heróis para a equipe:");

            for (int i = 0; i < contadorHerois; i++)
            {
                Console.WriteLine($"{i + 1}. Nome: {herois[i].Nome}, Poder: {herois[i].Poder}, Pontuação: {herois[i].Pontuacao}");
            }

            for (int i = 0; i < 3; i++)
            {
                int selecao;
                do
                {
                    Console.Write($"Selecione o herói {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out selecao) || selecao < 1 || selecao > contadorHerois);

                equipe.Herois[i] = herois[selecao - 1]; // Adiciona o herói selecionado na equipe
            }

            calcularPontuacaoTotal();
        }

        static void calcularPontuacaoTotal()
        {
            equipe.PontuacaoTotal = 0;
            foreach (var heroi in equipe.Herois)
            {
                equipe.PontuacaoTotal += heroi.Pontuacao; // Soma a pontuação dos heróis da equipe
            }

            Console.WriteLine("Equipe selecionada com sucesso!");
        }

        static void exibirEquipe()
        {
            if (equipe.Herois[0].Nome == null)
            {
                Console.WriteLine("Nenhuma equipe foi selecionada ainda.");
                return;
            }

            Console.WriteLine("Equipe Selecionada:");
            foreach (var heroi in equipe.Herois)
            {
                Console.WriteLine($"Nome: {heroi.Nome}, Poder: {heroi.Poder}, Pontuação: {heroi.Pontuacao}");
            }
            Console.WriteLine($"Pontuação Total da Equipe: {equipe.PontuacaoTotal}");
        }
    }
}