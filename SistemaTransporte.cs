using System;
using System.Collections.Generic;
using System.Linq;

namespace TransportePilha
{
    public class SistemaTransporte
    {
        public List<Veiculo> Frota { get; private set; }
        public List<Garagem> Garagens { get; private set; }
        public List<Viagem> Viagens { get; private set; }
        public bool JornadaAtiva { get; private set; }

        public SistemaTransporte()
        {
            Frota = new List<Veiculo>();
            Garagens = new List<Garagem>();
            Viagens = new List<Viagem>();
            JornadaAtiva = false;
        }

        public void CadastrarVeiculo(int numero, int capacidade)
        {
            Frota.Add(new Veiculo(numero, capacidade));
        }

        public void CadastrarGaragem(string nome)
        {
            Garagens.Add(new Garagem(nome));
        }

        public void IniciarJornada()
        {
            JornadaAtiva = true;

            int i = 0;
            foreach (var v in Frota)
            {
                Garagens[i % Garagens.Count].Estacionar(v);
                i++;
            }
        }

        public void EncerrarJornada()
        {
            JornadaAtiva = false;

            Console.WriteLine("\n=== Relatório Final ===");
            Console.WriteLine("Total de viagens: " + Viagens.Count);
            Console.WriteLine("Total de passageiros: " + Viagens.Sum(v => v.Passageiros));
        }

        public void LiberarViagem(string origem, string destino, int passageiros)
        {
            var gOrigem = Garagens.FirstOrDefault(g => g.Nome == origem);
            var gDestino = Garagens.FirstOrDefault(g => g.Nome == destino);

            if (gOrigem == null || gDestino == null)
            {
                Console.WriteLine("Garagem não encontrada!");
                return;
            }

            var veiculo = gOrigem.Retirar();

            if (veiculo == null)
            {
                Console.WriteLine("Nenhum veículo disponível na origem!");
                return;
            }

            gDestino.Estacionar(veiculo);

            Viagens.Add(new Viagem(gOrigem, gDestino, veiculo, passageiros));
        }

        public void ListarVeiculos(string garagem)
        {
            var g = Garagens.FirstOrDefault(x => x.Nome == garagem);

            if (g == null)
            {
                Console.WriteLine("Garagem não encontrada!");
                return;
            }

            Console.WriteLine($"=== Veículos na garagem {g.Nome} ===");
            foreach (var v in g.Veiculos)
            {
                Console.WriteLine(v);
            }
        }

        public void ListarViagens(string origem, string destino)
        {
            var lista = Viagens.Where(v => v.Origem.Nome == origem && v.Destino.Nome == destino);

            foreach (var v in lista)
                Console.WriteLine(v);
        }
    }
}
