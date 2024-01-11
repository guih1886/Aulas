using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaFormNovoLeilao
    {
        private IWebDriver driver;
        private LoginPO loginPO;
        private NovoLeilaoPO novoLeilaoPO;

        public AoNavegarParaFormNovoLeilao(TestFixture fixture)
        {
            this.driver = fixture.Driver;
            loginPO = new LoginPO(this.driver);
            novoLeilaoPO = new NovoLeilaoPO(this.driver);
        }

        [Fact]
        public void DadoLoginAdmDeveMostrarTresCategorias()
        {
            //Assert
            loginPO.VisitarUrlLogin();
            loginPO.PreencheFormularioLogin("fulano@example.org", "123");
            loginPO.SubmeterFormularioLogin();

            //Act
            novoLeilaoPO.Visitar();

            //Assert
            Assert.Equal(3, novoLeilaoPO.Categorias.Count());
        }
    }
}
