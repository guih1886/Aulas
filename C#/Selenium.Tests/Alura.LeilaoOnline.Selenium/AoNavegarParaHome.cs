using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium
{
    public class AoNavegarParaHome
    {
       
        [Fact]
        public void DeveMostrarLeiloesNoTitulo()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //Act
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //Assert
            Assert.Contains("Leilões", driver.Title);
        }
    }
}
