namespace TransportePilha
{
    public class Viagem
    {
        public Garagem Origem { get; set; }
        public Garagem Destino { get; set; }
        public Veiculo Veiculo { get; set; }
        public int Passageiros { get; set; }

        public Viagem(Garagem origem, Garagem destino, Veiculo veiculo, int passageiros)
        {
            Origem = origem;
            Destino = destino;
            Veiculo = veiculo;
            Passageiros = passageiros;
        }

        public override string ToString()
        {
            return $"Origem: {Origem.Nome} | Destino: {Destino.Nome} | Veículo: {Veiculo.Numero} | Passageiros: {Passageiros}";
        }
    }
}
