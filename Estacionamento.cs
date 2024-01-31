using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LalaCar
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void adicionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo:");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x.Equals(placa)))
            {
                Console.WriteLine("Já existe um veículo com essa placa.");
            } else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso.");
            }
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo a ser removido:");
            string placa = Console.ReadLine().ToUpper();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas do veículo no pátio:");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal precoTotal = precoInicial + precoHora * horas;

                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo de placa {placa} foi removido com sucesso.");
                    Console.WriteLine($"Horas no pátio: {horas}. Deve pagar {precoTotal} reais.");

            } else
                {
                Console.WriteLine($"Veículo de placa {placa} não encontrado.");
            }
        }

        public void listarVeiculo()
        {
            if ( veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados nos momento são:");
                foreach ( var v in veiculos )
                {
                    Console.WriteLine(v);
                }
            } else
            { 
                    Console.WriteLine("Não há veículos estacionados no momento.");
            }
        }

    }
}
