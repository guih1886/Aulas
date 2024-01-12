using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarLogout
    {
        private IWebDriver driver;
        private LoginPO loginPO;
        private DashboardInteressadaPO dashboardPO;

        public AoEfetuarLogout(TestFixture fixture)
        {
            driver = fixture.Driver;
            loginPO = new LoginPO(driver);
            dashboardPO = new DashboardInteressadaPO(driver);
        }

        [Fact]
        public void DadoLoginValidoDeveIrParaHome()
        {
            //Arrange
            loginPO.EfetuarLoginComCredenciais("fulano@example.org", "123");

            //Act
            dashboardPO.Menu.EfetuarLogout();

            //Assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
        }
    }
}
