using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoFiltrarLeiloes
    {
        private IWebDriver driver;
        private LoginPO loginPO;
        private DashboardInteressadaPO dashboardInteressadaPO;

        public AoFiltrarLeiloes(TestFixture fixture)
        {
            this.driver = fixture.Driver;
            loginPO = new LoginPO(this.driver);
            dashboardInteressadaPO = new DashboardInteressadaPO(this.driver);
        }

        [Fact]
        public void DadoLoginInteressadoDeveMostrarPainelResultado()
        {
            //Arrange
            loginPO.EfetuarLoginComCredenciais("fulano@example.org", "123");
            //Act
            dashboardInteressadaPO.Filtro.PesquisaLeiloes(
                new List<string> { "Arte", "Coleções" },
                "",
                true
             );
            //Assert
            Assert.Contains("Resultado da pesquisa", driver.PageSource);

        }
    }
}