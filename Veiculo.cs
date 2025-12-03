using System;

namespace TransportePilha
{
    public class Veiculo
    {
        public int Numero { get; set; }
        public int Capacidade { get; set; }

        public Veiculo(int numero, int capacidade)
        {
            Numero = numero;
            Capacidade = capacidade;
        }

        public override string ToString()
        {
            return $"Veículo {Numero} - Capacidade: {Capacidade}";
        }
    }
}
