using OpenQA.Selenium;
using System;

namespace Alura.ByteBank.Apresentacao.Testes.PageObjects
{
    public class ClientePO
    {
        private IWebDriver driver;

        public ClientePO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navegar(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClicarAdicionarCliente()
        {
            driver.FindElement(By.LinkText("Cliente")).Click();
            driver.FindElement(By.LinkText("Adicionar Cliente")).Click();
        }

        public void PreencheFormularioAdicionarCliente(Guid guid, string CPF, string nome, string profissao)
        {
            driver.FindElement(By.Name("Identificador")).Click();
            driver.FindElement(By.Name("Identificador")).SendKeys(guid.ToString());

            driver.FindElement(By.Name("CPF")).Click();
            driver.FindElement(By.Name("CPF")).SendKeys(CPF);

            driver.FindElement(By.Name("Nome")).Click();
            driver.FindElement(By.Name("Nome")).SendKeys(nome);

            driver.FindElement(By.Name("Profissao")).Click();
            driver.FindElement(By.Name("Profissao")).SendKeys(profissao);
        }

        public void btnCliente()
        {
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
        }
    }
}