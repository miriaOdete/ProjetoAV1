using ProjetoAV1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Gerenciar Empresa");
            Console.WriteLine("2. Cadastro de Cliente");
            Console.WriteLine("3. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExecutarGerenciarEmpresa();
                    break;
                case "2":
                    ExecutarCadastroCliente();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void ExecutarGerenciarEmpresa()
    {
        Funcionario empresa = new Funcionario("InnovaTech", 0, "");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Contratar funcionário");
            Console.WriteLine("2. Listar funcionários");
            Console.WriteLine("3. Demitir funcionário");
            Console.WriteLine("4. Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do funcionário: ");
                    string nomeFuncionario = Console.ReadLine();
                    Console.Write("Idade do funcionário: ");
                    int idadeFuncionario = int.Parse(Console.ReadLine());
                    Console.Write("CPF do funcionário: ");
                    string cpfFuncionario = Console.ReadLine();
                    empresa.Contratar(nomeFuncionario, idadeFuncionario, cpfFuncionario);
                    break;
                case "2":
                    empresa.ListarFuncionarios();
                    break;
                case "3":
                    Console.Write("Nome do funcionário a ser demitido: ");
                    string nomeFuncionarioDemitir = Console.ReadLine();
                    var funcionarioDemitir = empresa.Funcionarios.Find(f => f.Nome == nomeFuncionarioDemitir);
                    if (funcionarioDemitir != null)
                    {
                        empresa.Demitir(funcionarioDemitir);
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void ExecutarCadastroCliente()
       {
          Console.WriteLine("Cadastro de Cliente");

          Console.Write("Nome: ");
          string nome = Console.ReadLine();

          Console.Write("Idade: ");
          int idade = int.Parse(Console.ReadLine()); 

          Console.Write("Endereço: ");
          string endereco = Console.ReadLine();

          Console.Write("Telefone: ");
          int telefone = int.Parse(Console.ReadLine()); 

       
          Cliente cliente = new Cliente(nome, idade, endereco, telefone);

    
          Console.WriteLine("\nDetalhes do Cliente:");
          cliente.ExibirDetalhes();
        }

}