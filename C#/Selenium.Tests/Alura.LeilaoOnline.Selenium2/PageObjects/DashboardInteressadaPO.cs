using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class DashboardInteressadaPO
    {
        private IWebDriver driver;
        public FiltroLeiloesPO Filtro { get; }
        public MenuPO Menu { get; }

        public DashboardInteressadaPO(IWebDriver driver)
        {
            this.driver = driver;
            Filtro = new FiltroLeiloesPO(driver);
            Menu = new MenuPO(driver);
        }
    }
}