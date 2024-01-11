using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class DashboardInteressadaPO
    {
        private IWebDriver driver;
        private By logoutLink;
        private By meuPerfil;

        public DashboardInteressadaPO(IWebDriver driver)
        {
            this.driver = driver;
            logoutLink = By.Id("logout");
            meuPerfil = By.Id("meu-perfil");
        }

        public void EfetuarLogout()
        {
            //Ação para mover o cursor
            IAction acaoLogout = new Actions(driver)
                .MoveToElement(driver.FindElement(meuPerfil))
                .MoveToElement(driver.FindElement(logoutLink))
                .Click()
                .Build();
            acaoLogout.Perform();
        }
    }
}