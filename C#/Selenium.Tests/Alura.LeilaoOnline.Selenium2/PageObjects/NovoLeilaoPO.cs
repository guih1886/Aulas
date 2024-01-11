using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Alura.LeilaoOnline.Selenium2.PageObjects
{
    public class NovoLeilaoPO
    {
        private IWebDriver driver;
        private By titulo;
        private By descricao;
        private By categoria;
        private By valorInicial;
        private By inicioPregao;
        private By terminoPregao;
        private By imagem;
        private By btnSalvar;

        public IEnumerable<string> Categorias
        {
            get
            {
                var elementoCategoria = new SelectElement(driver.FindElement(categoria));
                return elementoCategoria.Options.Where(o => o.Enabled).Select(o => o.Text);
            }
        }

        public NovoLeilaoPO(IWebDriver driver)
        {
            this.driver = driver;
            titulo = By.Id("Titulo");
            descricao = By.Id("Descricao");
            categoria = By.Id("Categoria");
            valorInicial = By.Id("ValorInicial");
            inicioPregao = By.Id("InicioPregao");
            terminoPregao = By.Id("TerminoPregao");
            imagem = By.Id("ArquivoImagem");
            btnSalvar = By.CssSelector("button[type=submit]");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Leiloes/Novo");
        }

        public void PreencheFormularioNovoLeilao(
            string titulo,
            string descricao,
            string categoria, double valor, string imagem, DateTime inicio, DateTime termino)
        {
            driver.FindElement(this.titulo).SendKeys(titulo);
            driver.FindElement(this.descricao).SendKeys(descricao);
            //driver.FindElement(this.categoria).SendKeys(categoria);
            driver.FindElement(this.valorInicial).SendKeys(valor.ToString());
            driver.FindElement(this.inicioPregao).SendKeys(inicio.ToString("dd/MM/yyyy"));
            driver.FindElement(this.terminoPregao).SendKeys(termino.ToString("dd/MM/yyyy"));
            driver.FindElement(this.imagem).SendKeys(imagem);
        }

        public void SubmeteFormularioNovoLeilao()
        {
            driver.FindElement(btnSalvar).Submit();
        }

    }
}
