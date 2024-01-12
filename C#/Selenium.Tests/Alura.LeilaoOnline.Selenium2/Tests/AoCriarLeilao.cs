using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoCriarLeilao
    {
        private IWebDriver driver;
        private LoginPO loginPO;
        private NovoLeilaoPO novoPO;

        public AoCriarLeilao(TestFixture fixture)
        {
            this.driver = fixture.Driver;
            loginPO = new LoginPO(this.driver);
            novoPO = new NovoLeilaoPO(this.driver);
        }

        [Fact]
        public void DadoLoginAdminEInfoEmailValidaDeveCadastrarLeilao()
        {
            //Arrange
            loginPO.EfetuarLoginComCredenciais("fulano@example.org", "123");

            novoPO.Visitar();
            novoPO.PreencheFormularioNovoLeilao(
                "Leilão de Coleção",
                "Lorem ipsum dolor sit amet. Non autem voluptatem sed laboriosam alias et adipisci reiciendis. Ea exercitationem dolorum et eligendi commodi non dolores eligendi sed quidem eligendi sit maxime consequatur. Aut laborum esse eos voluptatum dolorem in cupiditate corrupti sed sint recusandae. Qui internos repellat qui ducimus magnam a earum voluptatem aut neque placeat est ullam sint eos galisum doloremque.",
                "Item de Colecionador",
                4000,
                "C:\\Users\\guilh\\Pictures\\Screenshots\\1.png",
                DateTime.Now,
                DateTime.Now.AddDays(20)
                );

            //Act
            novoPO.SubmeteFormularioNovoLeilao();

            //Assert
            Assert.Contains("Leilões cadastrados no sistema", driver.PageSource);
        }
    }
}
