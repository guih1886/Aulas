using Alura.LeilaoOnline.Selenium2.Fixtures;
using OpenQA.Selenium;
using System.ComponentModel;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class FiltroLeiloesPO
    {
        private IWebDriver driver;
        private By selectCategorias;
        private By inputTermo;
        private By inputAndamento;
        private By botaoPesquisar;

        public FiltroLeiloesPO(IWebDriver driver)
        {
            this.driver = driver;
            selectCategorias = By.ClassName("select-wrapper");
            inputTermo = By.Id("termo");
            inputAndamento = By.ClassName("switch");
            botaoPesquisar = By.CssSelector("form>button.btn");
        }

        public void PesquisaLeiloes(List<string> categorias, string termo, bool emAndamento = true)
        {
            var select = new SelectSerializer(driver, selectCategorias);
            select.DeselectAll();

            categorias.ForEach(categ =>
            {
                select.SelectByText(categ);
            });

            driver.FindElement(inputTermo).SendKeys(termo);
            if (emAndamento)
            {
                driver.FindElement(inputAndamento).Click();
            }
            driver.FindElement(botaoPesquisar).Click();
        }
    }
}
