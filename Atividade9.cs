using System;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("       PERFIL DO USUÁRIO");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nome de usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("O perfil está ativo? (true/false): ");
            bool ativo = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       DADOS DO USUÁRIO");
            Console.WriteLine("=================================");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Usuário: " + usuario);
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("Cidade: " + cidade);
            Console.WriteLine("Altura: " + altura + " metros");
            Console.WriteLine("Perfil ativo: " + ativo);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
