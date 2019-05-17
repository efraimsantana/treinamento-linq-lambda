using System;

namespace ConsoleApp3
{
    public class Locacao
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }

        public Locacao(Cliente cliente, Carro carro)
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
            Carro = carro;
        }
    }
}