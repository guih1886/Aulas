
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class LoginPO
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

        public void EfetuarLoginComCredenciais(string login, string senha)
        {
            //Navega para págiona de login
            driver.Navigate().GoToUrl("http://localhost:5000/Autenticacao/Login");
            //Preenche o formulario
            driver.FindElement(inputLogin).SendKeys(login);
            driver.FindElement(inputSenha).SendKeys(senha);
            //Submete Formulario
            driver.FindElement(botaoLogin).Submit();
        }
    }
}