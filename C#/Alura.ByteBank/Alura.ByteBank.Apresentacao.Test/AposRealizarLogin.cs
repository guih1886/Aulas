using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit.Abstractions;
using Xunit;
using System;

namespace Alura.ByteBank.Apresentacao.Testes
{
    public class AposRealizarLogin : IDisposable
    {
        public IWebDriver driver { get; private set; }
        private ITestOutputHelper output;
        private string url = "https://localhost:5001/";
        public AposRealizarLogin(ITestOutputHelper _output)
        {
            this.output = _output;
            driver = new ChromeDriver();
            LogarNoSistema("andre@email.com", "senha01");
        }

        public void LogarNoSistema(string email, string senha)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Size = new System.Drawing.Size(1294, 1032);
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys(email);
            driver.FindElement(By.Id("Senha")).Click();
            driver.FindElement(By.Id("Senha")).SendKeys(senha);
            driver.FindElement(By.Id("btn-logar")).Click();
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

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
