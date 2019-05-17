using System;

namespace ConsoleApp3
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Categoria Departamento { get; set; }
        public Marca Marca { get; set; }

        public Carro(string nome, decimal preco, Categoria departamento, Marca marca)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco;
            Departamento = departamento;
            Marca = marca;
        }
    }
}
