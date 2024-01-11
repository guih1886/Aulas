using Alura.LeilaoOnline.Selenium2.Fixture;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using Xunit;
using Xunit.Abstractions;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaHome
    {
        private IWebDriver driver;
        private ITestOutputHelper output;

        //Setup
        public AoNavegarParaHome(TestFixture fixture, ITestOutputHelper _output)
        {
            driver = fixture.Driver;
            output = _output;
        }

        [Fact]
        public void DeveMostrarLeiloesNoTitulo()
        {
            //Arrange
            //Act
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //Assert
            Assert.Contains("Leilões", driver.Title);
        }

        [Fact]
        public void DadoNavegadorAbertoDeveMostrarProximosLeiloes()
        {
            //Act
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //Assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
        }

        [Fact]
        public void DadoNavegadorAbertoNaoDeveMostrarMensagensDeErro()
        {
            //Arrange
            driver.Navigate().GoToUrl("http://localhost:5000/");
            var erros = driver.FindElements(By.CssSelector("form span"));
            //Act
            //Assert
            foreach (var erro in erros)
            {
                Assert.True(string.IsNullOrEmpty(erro.Text));
            }
        }
    }
}
