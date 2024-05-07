using ProjetoAV1;

namespace TestProjeto
{
    [TestClass]
    public class FuncionarioTest
    {
        [TestMethod]

        public void TestContratar()
        {
            // Arrange
            string nomeEmpresa = "Empresa ABC";
            Funcionario empresa = new Funcionario(nomeEmpresa, 0, "000.000.000-00");
            string nomeFuncionario = "João";
            int idadeFuncionario = 30;
            string cpfFuncionario = "111.111.111-11";

            // Act
            empresa.Contratar(nomeFuncionario, idadeFuncionario, cpfFuncionario);

            // Assert
            Assert.AreEqual(1, empresa.Funcionarios.Count);
            Assert.AreEqual(nomeFuncionario, empresa.Funcionarios[0].Nome);
            Assert.AreEqual(idadeFuncionario, empresa.Funcionarios[0].Idade);
            Assert.AreEqual(cpfFuncionario, empresa.Funcionarios[0].CPF);
        }

        [TestMethod]
        public void TestDemitir()
        {
            // Arrange
            string nomeEmpresa = "Empresa XYZ";
            Funcionario empresa = new Funcionario(nomeEmpresa, 0, "000.000.000-00");
            string nomeFuncionario = "Maria";
            int idadeFuncionario = 25;
            string cpfFuncionario = "222.222.222-22";
            Funcionario funcionario = new Funcionario(nomeFuncionario, idadeFuncionario, cpfFuncionario);
            empresa.Funcionarios.Add(funcionario);

            // Act
            empresa.Demitir(funcionario);

            // Assert
            Assert.AreEqual(0, empresa.Funcionarios.Count);


        }
       
    }
       
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void TestCriarCliente()
        {
           
            string nome = "Ana";
            int idade = 35;
            string endereco = "Rua ABC, 123";
            int telefone = 123456789;

            
            Cliente cliente = new Cliente(nome, idade, endereco, telefone);

            
            Assert.AreEqual(nome, cliente.Nome);
            Assert.AreEqual(idade, cliente.Idade);
            Assert.AreEqual(endereco, cliente.Endereco);
            Assert.AreEqual(telefone, cliente.Telefone);
        }
        [TestMethod]
           public void TestExibirDetalhes()
            {
                
                string nome = "Pedro";
                int idade = 40;
                string endereco = "Av. XYZ, 456";
                int telefone = 987654321;

                
                Cliente cliente = new Cliente(nome, idade, endereco, telefone);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    cliente.ExibirDetalhes();
                    string expectedOutput = $"Nome: {nome}, Idade: {idade}, Endereco: {endereco}, Telefone: {telefone}{Environment.NewLine}";
                    Assert.AreEqual(expectedOutput, sw.ToString());
                }
            }


     }
}
