using System.Collections.Generic;

namespace TransportePilha
{
    public class Garagem
    {
        public string Nome { get; set; }
        public Stack<Veiculo> Veiculos { get; private set; }

        public Garagem(string nome)
        {
            Nome = nome;
            Veiculos = new Stack<Veiculo>();
        }

        public void Estacionar(Veiculo v)
        {
            Veiculos.Push(v);
        }

        public Veiculo Retirar()
        {
            if (Veiculos.Count == 0)
                return null;

            return Veiculos.Pop();
        }

        public override string ToString()
        {
            return $"{Nome} (Veículos: {Veiculos.Count})";
        }
    }
}
