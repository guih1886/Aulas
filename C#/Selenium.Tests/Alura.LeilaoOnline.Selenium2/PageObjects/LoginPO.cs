
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    internal class LoginPO
    {
        private IWebDriver driver;

        private By inputLogin;
        private By inputSenha;
        private By botaoLogin;

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
            inputLogin = By.Id("Login");
            inputSenha = By.Id("Password");
            botaoLogin = By.Id("btnLogin");
        }

        public void VisitarUrlLogin()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Autenticacao/Login");
        }

        public void PreencheFormularioLogin(string login, string senha)
        {
            driver.FindElement(inputLogin).SendKeys(login);
            driver.FindElement(inputSenha).SendKeys(senha);
        }

        public void SubmeterFormularioLogin()
        {
            driver.FindElement(botaoLogin).Submit();
        }
    }
}