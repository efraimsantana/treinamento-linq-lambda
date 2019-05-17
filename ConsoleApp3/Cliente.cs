using System;

namespace ConsoleApp3
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}