using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAV1
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }

        public int Telefone { get; set; }

        public Cliente(string nome, int idade, string endereco, int telefone)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Endereco: {Endereco}, Telefone: {Telefone}");
        }
    }
}
