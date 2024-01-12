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
            //Act
            loginPO.EfetuarLoginComCredenciais("fulano@example.org", "123");

            //Assert
            Assert.Contains("Dashboard", driver.PageSource);
        }

        [Fact]
        public void ValidaCredenciaisLoginIncorrretas()
        {
            //Arrange
            //Act
            loginPO.EfetuarLoginComCredenciais("fulano@emaple.org.com", "");
            //Assert
            Assert.Contains("Login", driver.PageSource);
        }
    }
}
