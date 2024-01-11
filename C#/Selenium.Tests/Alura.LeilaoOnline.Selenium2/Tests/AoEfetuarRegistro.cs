using Alura.LeilaoOnline.Selenium2.Fixture;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarRegistro
    {
        private IWebDriver driver;
        private string url;

        public AoEfetuarRegistro(TestFixture fixture)
        {
            driver = fixture.Driver;
            url = fixture.urlBase;
        }

        [Fact]
        public void DadoInfoValidasDeveIrParaPaginaDeAgradecimento()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            string senha = Guid.NewGuid().ToString();
            //Act - Efeturar o registro
            driver.FindElement(By.Id("Nome")).SendKeys("Adalberto Magalhães");
            driver.FindElement(By.Id("Email")).SendKeys("adalberto@email.com");
            driver.FindElement(By.Id("Password")).SendKeys(senha);
            driver.FindElement(By.Name("ConfirmPassword")).SendKeys(senha);

            driver.FindElement(By.Id("btnRegistro")).Click();
            //Assert - Devo ser direcionado para a página de agradecimento
            Assert.Contains("Obrigado", driver.PageSource);
        }

        [Theory]
        [InlineData("", "", "", "")]
        [InlineData("Guilherme", "guilherme@email.com", "1234", "123")]
        [InlineData("Guilherme", "", "1234", "1234")]
        [InlineData("Guilherme", "guilherme@email.com", "", "1234")]
        public void DadoInfoInvalidasDeveContinuarNaHome(string nome, string email, string senha, string confirmSenha)
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            //Act - Efeturar o registro
            driver.FindElement(By.Id("Nome")).SendKeys(nome);
            driver.FindElement(By.Id("Email")).SendKeys(email);
            driver.FindElement(By.Id("Password")).SendKeys(senha);
            driver.FindElement(By.Name("ConfirmPassword")).SendKeys(confirmSenha);

            driver.FindElement(By.Id("btnRegistro")).Click();
            //Assert - Devo ser direcionado para a página de agradecimento
            Assert.Contains("Leilões Online", driver.Title);
        }

        [Fact]
        public void DadoNomeEmBrancoDeveMostrarMensagemDeErro()
        {
            //Arrange
            driver.Navigate().GoToUrl(url);
            //Act
            driver.FindElement(By.Id("btnRegistro")).Click();
            //Assert
            IWebElement elemento = driver.FindElement(By.Id("Nome-error"));
            Assert.Equal("The Nome field is required.", elemento.Text);
        }
    }
}
