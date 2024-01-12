using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoOfertarLance
    {
        private IWebDriver driver;
        private LoginPO loginPO;
        private DetalheLeilaoPO detalheLeilaoPO;

        public AoOfertarLance(TestFixture fixture)
        {
            this.driver = fixture.Driver;
            loginPO = new LoginPO(this.driver);
            detalheLeilaoPO = new DetalheLeilaoPO(this.driver);
        }

        [Fact]
        public void DadoLoginInteressadoDeveEfetuarLance()
        {
            //Arrange
            loginPO.EfetuarLoginComCredenciais("fulano@example.org", "123");

            detalheLeilaoPO.VisitarUrlLeilao(1); //Em andamento

            //Act
            detalheLeilaoPO.OfertarLance(500);
            //Esperar a atualização do lance
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            var iguais = wait.Until(resp => detalheLeilaoPO.LanceAtual == 500);

            //Assert
            Assert.True(iguais);
        }
    }
}
