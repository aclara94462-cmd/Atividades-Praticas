using System;

namespace Atividade8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("=================================");
            Console.WriteLine("       CADASTRO DE EVENTO");
            Console.WriteLine("=================================");

            // Cadastro dos dados
            Console.Write("Nome do evento: ");
            string nome = Console.ReadLine();

            Console.Write("Local: ");
            string local = Console.ReadLine();

            Console.Write("Data: ");
            string data = Console.ReadLine();

            Console.Write("Quantidade de participantes: ");
            int participantes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor do ingresso: ");
            double ingresso = Convert.ToDouble(Console.ReadLine());

            Console.Write("O evento é gratuito? (true/false): ");
            bool gratuito = Convert.ToBoolean(Console.ReadLine());

            // Exibição dos dados
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("       DADOS DO EVENTO");
            Console.WriteLine("=================================");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Local: " + local);
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Participantes: " + participantes);
            Console.WriteLine("Valor do ingresso: " + ingresso);
            Console.WriteLine("Evento gratuito: " + gratuito);

            // Mantém o console aberto
            Console.ReadKey();
        }
    }
}
