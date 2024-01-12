using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class DetalheLeilaoPO
    {
        private IWebDriver driver;

        private By inputValor;
        private By lanceAtual;
        private By btnDarLance;
        public double LanceAtual
        {
            get
            {
                var valorTexto = driver.FindElement(lanceAtual).Text;
                var valor = double.Parse(valorTexto, System.Globalization.NumberStyles.Currency);
                return valor;
            }
        }

        public DetalheLeilaoPO(IWebDriver driver)
        {
            this.driver = driver;
            inputValor = By.Id("Valor");
            lanceAtual = By.Id("lanceAtual");
            btnDarLance = By.Id("btnDarLance");
        }


        public void VisitarUrlLeilao(int idLeilao)
        {
            driver.Navigate().GoToUrl($"http://localhost:5000/Home/Detalhes/{idLeilao}");
        }

        public void OfertarLance(double valor)
        {
            driver.FindElement(inputValor).Clear();
            driver.FindElement(inputValor).SendKeys(valor.ToString());
            driver.FindElement(btnDarLance).Click();
        }
    }
}