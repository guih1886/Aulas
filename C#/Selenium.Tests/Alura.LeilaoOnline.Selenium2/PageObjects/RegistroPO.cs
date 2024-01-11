using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class RegistroPO
    {
        public IWebDriver driver;
        private By formRegistro;
        private By inputNome;
        private By inputEmail;
        private By inputSenha;
        private By inputConfirmSenha;
        private By botaoRegistro;
        private By erroNome;

        public string MensagemErro => driver.FindElement(erroNome).Text;
        public ReadOnlyCollection<IWebElement> FormSpan => driver.FindElements(By.CssSelector("form span"));

        public RegistroPO(IWebDriver _driver)
        {
            driver = _driver;
            formRegistro = By.TagName("form");
            inputNome = By.Id("Nome");
            inputEmail = By.Id("Email");
            inputSenha = By.Id("Password");
            inputConfirmSenha = By.Id("ConfirmPassword");
            botaoRegistro = By.Id("btnRegistro");
            erroNome = By.Id("Nome-error");
        }

        public void VisitarUrlBase()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        public void PreencheFormularioNovoUsuario(string nome, string email, string senha, string confirmSenha)
        {
            driver.FindElement(inputNome).SendKeys(nome);
            driver.FindElement(inputEmail).SendKeys(email);
            driver.FindElement(inputSenha).SendKeys(senha);
            driver.FindElement(inputConfirmSenha).SendKeys(confirmSenha);
        }

        public void SubmeteFormuarioCadastroUsuario()
        {
            driver.FindElement(botaoRegistro).Click();
        }
    }
}
