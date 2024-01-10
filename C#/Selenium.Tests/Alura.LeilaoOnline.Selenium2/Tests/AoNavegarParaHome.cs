using Alura.LeilaoOnline.Selenium2.Fixture;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaHome
    {
        private IWebDriver driver;

        //Setup
        public AoNavegarParaHome(TestFixture fixture)
        {
            driver = fixture.Driver;
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
    }
}
