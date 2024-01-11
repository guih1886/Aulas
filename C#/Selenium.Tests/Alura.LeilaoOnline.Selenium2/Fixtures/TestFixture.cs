using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit.Abstractions;

namespace Alura.LeilaoOnline.Selenium2.Fixture
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public string urlBase = "http://localhost:5000/";

        public TestFixture()
        {
            Driver = new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
