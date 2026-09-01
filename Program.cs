using System;

namespace Atividade10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título do sistema
            Console.WriteLine("=================================");
            Console.WriteLine("      CADASTRO DE EMPRESA");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Nome da empresa: ");
            string nome = Console.ReadLine();

            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine();

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Nome do responsável: ");
            string responsavel = Console.ReadLine();

            Console.Write("Número de funcionários: ");
            int funcionarios = Convert.ToInt32(Console.ReadLine());

            Console.Write("Faturamento mensal: ");
            double faturamento = Convert.ToDouble(Console.ReadLine());

            Console.Write("A empresa está ativa? (true/false): ");
            bool ativa = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados cadastrados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("      DADOS DA EMPRESA");
            Console.WriteLine("=================================");

            Console.WriteLine("Nome da empresa: " + nome);
            Console.WriteLine("CNPJ: " + cnpj);
            Console.WriteLine("Cidade: " + cidade);
            Console.WriteLine("Responsável: " + responsavel);
            Console.WriteLine("Número de funcionários: " + funcionarios);
            Console.WriteLine("Faturamento mensal: " + faturamento);
            Console.WriteLine("Empresa ativa: " + ativa);

            // Mantém o console aberto
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
