using System;

namespace Atividade7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("         CADASTRO DE JOGO");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Nome do jogo: ");
            string nome = Console.ReadLine();

            Console.Write("Plataforma: ");
            string plataforma = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantidade de jogadores: ");
            int jogadores = Convert.ToInt32(Console.ReadLine());

            Console.Write("O jogo está instalado? (true/false): ");
            bool instalado = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("         DADOS DO JOGO");
            Console.WriteLine("=================================");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Plataforma: " + plataforma);
            Console.WriteLine("Ano de lançamento: " + ano);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Quantidade de jogadores: " + jogadores);
            Console.WriteLine("Instalado: " + instalado);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
