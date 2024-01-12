using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    internal class HomeNaoLogadaPO
    {
        private IWebDriver driver;
        public MenuNaoLogadoPO Menu {  get; set; }

        public HomeNaoLogadaPO(IWebDriver driver)
        {
            this.driver = driver;
            Menu = new MenuNaoLogadoPO(this.driver);
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
    }
}
