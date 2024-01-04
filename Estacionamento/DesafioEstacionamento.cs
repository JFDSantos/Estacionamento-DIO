using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Estacionamento
    {
        private decimal valorInicial = 0;
        private decimal valorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal valorInicial, decimal valorHora) {

            this.valorInicial = valorInicial;
            this.valorHora = valorHora;
        }

        public void cadastrarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();

            if (string.IsNullOrEmpty(placa)) 
            {
                Console.Clear();
                Console.WriteLine("Digite uma placa válida!\n");
                cadastrarVeiculo();
            }
            else
            {
                Console.Clear();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                    Console.WriteLine("O veículo já se encontra estacionado!\n");
                }
                else
                {
                    veiculos.Add(placa);
                }
                
            }
            
        }
        
        public void listarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");
                foreach (string x in veiculos)
                {
                    Console.WriteLine($"Veículo: {x}");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Não há nenhum veículo estacionado!");
            }
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo, o qual deseja retirar do estacionamento: ");

            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = valorInicial + valorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado!\n");
            }
        }
    }
}
