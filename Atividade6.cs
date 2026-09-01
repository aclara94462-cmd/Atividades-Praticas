using System;

namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("       CADASTRO DE VEÍCULO");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cor: ");
            string cor = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("O veículo está disponível para venda? (true/false): ");
            bool disponivel = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       DADOS DO VEÍCULO");
            Console.WriteLine("=================================");

            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Disponível: " + disponivel);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
