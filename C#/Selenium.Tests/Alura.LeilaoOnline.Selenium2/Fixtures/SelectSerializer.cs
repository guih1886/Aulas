using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Alura.LeilaoOnline.Selenium2.Fixtures
{
    internal class SelectSerializer
    {
        private IWebDriver driver;
        private IWebElement selectWrapper;
        private IEnumerable<IWebElement> opcoes;
        public IEnumerable<IWebElement> Options => opcoes;

        public SelectSerializer(IWebDriver driver, By selectCategorias)
        {
            this.driver = driver;
            selectWrapper = driver.FindElement(selectCategorias);
            opcoes = selectWrapper.FindElements(By.CssSelector("li>span"));
        }

        private void OpenWrapper()
        {
            selectWrapper.Click();
        }

        private void LoseFocus()
        {
            selectWrapper
                .FindElement(By.TagName("li"))
                .SendKeys(Keys.Tab);
        }

        public void DeselectAll()
        {
            OpenWrapper();
            opcoes.ToList().ForEach(o =>
            {
                o.Click();
            });
            LoseFocus();
        }

        public void SelectByText(string option)
        {
            OpenWrapper();
            opcoes
                .Where(o => o.Text.Contains(option))
                .ToList()
                .ForEach(o =>
                {
                    o.Click();
                });
            LoseFocus();
        }
    }
}