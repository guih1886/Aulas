using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarLogin
    {
        private IWebDriver driver;
        private LoginPO loginPO;

        public AoEfetuarLogin(TestFixture fixture)
        {
            driver = fixture.Driver;
            loginPO = new LoginPO(driver);
        }

        [Fact]
        public void ValidaCredenciaisLoginCorrretas()
        {
            //Arrange
            loginPO.VisitarUrlLogin();
            //Act
            loginPO.PreencheFormularioLogin("fulano@example.org", "123");
            loginPO.SubmeterFormularioLogin();
            //Assert
            Assert.Contains("Dashboard", driver.PageSource);
        }

        [Fact]
        public void ValidaCredenciaisLoginIncorrretas()
        {
            //Arrange
            loginPO.VisitarUrlLogin();
            //Act
            loginPO.PreencheFormularioLogin("fulano@emaple.org.com", "");
            loginPO.SubmeterFormularioLogin();
            //Assert
            Assert.Contains("Login", driver.PageSource);
        }
    }
}
