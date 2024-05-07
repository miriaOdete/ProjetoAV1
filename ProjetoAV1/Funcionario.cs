using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAV1
{
    public class Funcionario
    {
        public string Nome;
        public int Idade;
        public string CPF;
        public List<Funcionario> Funcionarios;

        public Funcionario(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            Funcionarios = new List<Funcionario>();
        }

        public void Contratar(string nome, int idade, string cpf)
        {
            Funcionario novoFuncionario = new Funcionario(nome, idade, cpf);
            Funcionarios.Add(novoFuncionario);
            Console.WriteLine($"Funcionário {nome} contratado pela empresa {Nome}.");
        }

        public void Demitir(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
            Console.WriteLine($"Funcionário {funcionario.Nome} demitido da empresa {Nome}.");
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine($"Funcionários da empresa {Nome}:");
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine(funcionario.Nome);
            }
        }
    }
}