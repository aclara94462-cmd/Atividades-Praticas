using System;

namespace Atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("        CADASTRO DE FILME");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Nome do filme: ");
            string filme = Console.ReadLine();

            Console.Write("Nome do diretor: ");
            string diretor = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Duração em minutos: ");
            int duracao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota do filme: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.Write("O filme já foi assistido? (true/false): ");
            bool assistido = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("        DADOS DO FILME");
            Console.WriteLine("=================================");

            Console.WriteLine("Filme: " + filme);
            Console.WriteLine("Diretor: " + diretor);
            Console.WriteLine("Ano de lançamento: " + ano);
            Console.WriteLine("Duração: " + duracao + " minutos");
            Console.WriteLine("Nota: " + nota);
            Console.WriteLine("Já foi assistido: " + assistido);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
