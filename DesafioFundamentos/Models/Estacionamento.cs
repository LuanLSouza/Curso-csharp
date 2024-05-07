
using DesafioFundamentos.Models;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> carros = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {   
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            carros.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            ListarVeiculos();
            Console.WriteLine("-----------");

            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            if (carros.Contains(placa))
            {   
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal preco = precoInicial + (precoHora * horas);
                carros.Remove(placa);
                Console.WriteLine($"Veículo {placa} removido com sucesso! Preço a pagar: {preco}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado!");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veiculos estacionados: ");
            foreach (string placa in carros)
            {
                Console.WriteLine(placa);
            }
        }

    }
}