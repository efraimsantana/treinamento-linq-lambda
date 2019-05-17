using System;

namespace ConsoleApp3
{
    public class Marca
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Marca(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
    }
}