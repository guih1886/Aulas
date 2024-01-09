using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit.Abstractions;
using Xunit;
using System;
using Alura.ByteBank.Apresentacao.Testes.PageObjects;

namespace Alura.ByteBank.Apresentacao.Testes
{
    public class AposRealizarLogin : IDisposable
    {
        public IWebDriver driver { get; private set; }
        private ITestOutputHelper output;
        private string url = "https://localhost:5001/";
        private LoginPO loginPO;
        private ClientePO clientePO;
        public AposRealizarLogin(ITestOutputHelper _output)
        {
            driver = new ChromeDriver();
            this.output = _output;
            this.loginPO = new LoginPO(driver);
            this.clientePO = new ClientePO(driver);
            LogarNoSistema("andre@email.com", "senha01");
        }

        public void LogarNoSistema(string email, string senha)
        {
            loginPO.Navegar(url + "UsuarioApps/Login");
            loginPO.PreencherCamposELogar(email, senha);
            loginPO.btnClick();
        }

        [Fact]
        public void AposLoginVerificaSeExisteOpcaoAgenciaMenu()
        {
            //Arrange
            //Act
            var linkAgencia = driver.FindElement(By.Id("agencia"));

            //Assert
            Assert.NotNull(linkAgencia);
        }

        [Fact]
        public void CadastraCliente()
        {
            //Arrange
            var guid = Guid.NewGuid();

            //Act          
            clientePO.Navegar(url + "Clientes/Index");
            clientePO.ClicarAdicionarCliente();
            clientePO.PreencheFormularioAdicionarCliente(guid, "601.811.150-00", "Adelberto Gaudencio", "Lavrador");
            clientePO.btnCliente();

            //Assert
            Assert.Contains(guid.ToString(), driver.PageSource);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
