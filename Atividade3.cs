using System;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("         CADASTRO DE LIVRO");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Título do livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Nome do autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ano de publicação: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número de páginas: ");
            int paginas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("O livro está disponível? (true/false): ");
            bool disponivel = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("         DADOS DO LIVRO");
            Console.WriteLine("=================================");

            Console.WriteLine("Título: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Ano de publicação: " + ano);
            Console.WriteLine("Número de páginas: " + paginas);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Disponível: " + disponivel);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
