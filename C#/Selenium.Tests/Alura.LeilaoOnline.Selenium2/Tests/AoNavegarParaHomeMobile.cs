using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    public class AoNavegarParaHomeMobile : IDisposable
    {
        private ChromeDriver driver;
        private HomeNaoLogadaPO homeNaoLogadaPO;

        [Fact]
        public void DadaLargura400DeveMostrarMenuMobile()
        {
            //Arrange
            var settings = new ChromiumMobileEmulationDeviceSettings();
            settings.Width = 992;
            settings.Height = 800;
            settings.UserAgent = "Custom";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(settings);
            this.driver = new ChromeDriver(options);
            homeNaoLogadaPO = new HomeNaoLogadaPO(this.driver);
            //Act
            homeNaoLogadaPO.Visitar();
            //Assert
            Assert.True(homeNaoLogadaPO.Menu.MenuMobileVisivel);
        }

        [Fact]
        public void DadaLargura993NaoDeveMostrarMenuMobile()
        {
            //Arrange
            var settings = new ChromiumMobileEmulationDeviceSettings();
            settings.Width = 993;
            settings.Height = 800;
            settings.UserAgent = "Custom";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(settings);
            this.driver = new ChromeDriver(options);
            homeNaoLogadaPO = new HomeNaoLogadaPO(this.driver);
            //Act
            homeNaoLogadaPO.Visitar();
            //Assert
            Assert.False(homeNaoLogadaPO.Menu.MenuMobileVisivel);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
