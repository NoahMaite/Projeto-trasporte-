using System;

namespace TransportePilha
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaTransporte sistema = new SistemaTransporte();

            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("0. Finalizar");
                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2. Cadastrar garagem");
                Console.WriteLine("3. Iniciar jornada");
                Console.WriteLine("4. Encerrar jornada");
                Console.WriteLine("5. Liberar viagem");
                Console.WriteLine("6. Listar veículos na garagem");
                Console.WriteLine("7. Listar viagens entre origem e destino");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Número do veículo: ");
                        int numero = int.Parse(Console.ReadLine());

                        Console.Write("Capacidade: ");
                        int capacidade = int.Parse(Console.ReadLine());

                        sistema.CadastrarVeiculo(numero, capacidade);
                        break;

                    case 2:
                        Console.Write("Nome da garagem: ");
                        string nome = Console.ReadLine();

                        sistema.CadastrarGaragem(nome);
                        break;

                    case 3:
                        sistema.IniciarJornada();
                        Console.WriteLine("Jornada iniciada!");
                        break;

                    case 4:
                        sistema.EncerrarJornada();
                        break;

                    case 5:
                        Console.Write("Origem: ");
                        string origem = Console.ReadLine();

                        Console.Write("Destino: ");
                        string destino = Console.ReadLine();

                        Console.Write("Passageiros: ");
                        int passageiros = int.Parse(Console.ReadLine());

                        sistema.LiberarViagem(origem, destino, passageiros);
                        break;

                    case 6:
                        Console.Write("Garagem: ");
                        string g = Console.ReadLine();
                        sistema.ListarVeiculos(g);
                        break;

                    case 7:
                        Console.Write("Origem: ");
                        string o = Console.ReadLine();
                        Console.Write("Destino: ");
                        string d = Console.ReadLine();

                        sistema.ListarViagens(o, d);
                        break;
                }
            }
        }
    }
}
