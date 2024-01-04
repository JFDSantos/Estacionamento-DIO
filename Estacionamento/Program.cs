// See https://aka.ms/new-console-template for more information
using DesafioEstacionamento;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal valorInicial;
        decimal valorHora;

        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("Digite o preço inicial: ");

        valorInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora: ");

        valorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento es = new Estacionamento(valorInicial, valorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    es.cadastrarVeiculo();
                    break;

                case "2":
                    Console.Clear();
                    es.removerVeiculo();
                    break;

                case "3":
                    Console.Clear();
                    es.listarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O programa se encerrou");
    }
}