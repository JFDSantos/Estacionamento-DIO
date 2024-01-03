using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Estacionamento
    {
        private decimal valorInicial = 0;
        private decimal valorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal valorInicial, decimal valorHora) {

            this.valorInicial = valorInicial;
            this.valorHora = valorHora;
        }

        public void cadastrarVeiculo(string placa)
        {

        } 
    }
}
