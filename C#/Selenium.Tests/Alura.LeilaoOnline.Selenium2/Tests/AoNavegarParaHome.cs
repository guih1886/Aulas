using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;
using Xunit.Abstractions;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaHome
    {
        private IWebDriver driver;
        private ITestOutputHelper output;
        private RegistroPO registroPO;

        //Setup
        public AoNavegarParaHome(TestFixture fixture, ITestOutputHelper _output)
        {
            driver = fixture.Driver;
            output = _output;
            registroPO = new RegistroPO(driver);
        }

        [Fact]
        public void DeveMostrarLeiloesNoTitulo()
        {
            //Arrange
            //Act
            registroPO.VisitarUrlBase();
            //Assert
            Assert.Contains("Leilões", driver.Title);
        }

        [Fact]
        public void DadoNavegadorAbertoDeveMostrarProximosLeiloes()
        {
            //Act
            registroPO.VisitarUrlBase();
            //Assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
        }

        [Fact]
        public void DadoNavegadorAbertoNaoDeveMostrarMensagensDeErro()
        {
            //Arrange
            registroPO.VisitarUrlBase();
            var erros = registroPO.FormSpan;
            //Act
            //Assert
            foreach (var erro in erros)
            {
                Assert.True(string.IsNullOrEmpty(erro.Text));
            }
        }
    }
}
