using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        public static List<Carro> Carros = null;
        public static List<Locacao> Locacoes = null;
        public static List<Cliente> ClientesBloqueados = null;

        private static void Main(string[] args)
        {
            var Fiat = new Marca("Ford");
            var Ford = new Marca("Fiat");

            var Economico = new Categoria("Economico");
            var Suv = new Categoria("SUV");
            var PickUp = new Categoria("PICK-UP");

            Carros = new List<Carro>()
            {
                new Carro("Fiat Novo Uno ", 40, Economico, Fiat),
                new Carro("Novo Ford Ka", 40, Economico, Ford),
                new Carro("Ford Ecosport 1.5 ", 100, Suv, Ford),
                new Carro("Fiat Toro 1.8", 150, PickUp, Fiat),
            };

            var Joao = new Cliente("Joao");
            var Pedro = new Cliente("Pedro");
            var Paulo = new Cliente("Paulo");

            Locacoes = new List<Locacao>()
            {
                new Locacao(Pedro, Carros[0]),
                new Locacao(Joao, Carros[1]),
                new Locacao(Paulo, Carros[2]),
                new Locacao(Joao, Carros[3]),
                new Locacao(Pedro, Carros[2]),
                new Locacao(Pedro, Carros[3]),
                new Locacao(Paulo, Carros[3]),
                new Locacao(Joao, Carros[2]),
                new Locacao(Paulo, Carros[3]),
                new Locacao(Joao, Carros[2]),
                new Locacao(Pedro, Carros[2]),
                new Locacao(Joao, Carros[3]),
                new Locacao(Paulo, Carros[3]),
                new Locacao(Pedro, Carros[2]),
            };

            ClientesBloqueados = new List<Cliente>()
            {
                Joao,
                Paulo
            };

            QuantoCadaClienteBloqueadoJaGastouComLocacao();

            Console.ReadKey();
        }

        public static void TotalDeCarros()
        {
        }

        public static void TotalDeCarrosPorCategoria()
        {
        }

        public static void ValorTotalDeCarrosPorCategoria()
        {
        }

        public static void PrecoTotalDosCarrosPorCategoriaEhMarca()
        {
        }

        public static void QuantasEhQualValorTotalDeLocacoesDoClientePedro()
        {
        }

        public static void ValorTotalDeLocacaoPorCliente()
        {
        }

        public static void QuantoCadaClienteBloqueadoJaGastouComLocacao()
        {
        }
    }
}