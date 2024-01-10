using Alura.LeilaoOnline.Selenium2.Fixture;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class ChromeDriver
    {
        private IWebDriver driver;

        public ChromeDriver(TestFixture fixture)
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
    }
}
