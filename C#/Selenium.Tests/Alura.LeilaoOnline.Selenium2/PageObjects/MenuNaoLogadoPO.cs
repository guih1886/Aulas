using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class MenuNaoLogadoPO
    {
        private IWebDriver driver;
        private By menuMobile;
        public bool MenuMobileVisivel
        {
            get
            {
                var elemento = driver.FindElement(menuMobile);
                return elemento.Displayed;
            }
        }

        public MenuNaoLogadoPO(IWebDriver driver)
        {
            this.driver = driver;
            menuMobile = By.ClassName("sidenav-trigger");
        }

    }
}