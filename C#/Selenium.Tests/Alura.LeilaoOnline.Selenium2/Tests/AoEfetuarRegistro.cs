using Alura.LeilaoOnline.Selenium2.Fixture;
using Alura.LeilaoOnline.Selenium2.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium2.Tests
{
    [Collection("Chrome Driver")]
    public class AoEfetuarRegistro
    {
        private IWebDriver driver;
        private RegistroPO registroPO;
        private string url;

        public AoEfetuarRegistro(TestFixture fixture)
        {
            driver = fixture.Driver;
            url = fixture.urlBase;
            registroPO = new RegistroPO(driver);
        }

        [Fact]
        public void DadoInfoValidasDeveIrParaPaginaDeAgradecimento()
        {
            //Arrange
            registroPO.VisitarUrlBase();
            string senha = Guid.NewGuid().ToString();
            //Act - Efeturar o registro
            registroPO.PreencheFormularioNovoUsuario("Adalberto Magalhães", "adalberto@email.com", senha, senha);

            registroPO.SubmeteFormuarioCadastroUsuario();
            //Assert - Devo ser direcionado para a página de agradecimento
            Assert.Contains("Obrigado", driver.PageSource);
        }

        [Theory]
        [InlineData("", "", "", "")]
        [InlineData("Guilherme", "guilherme@email.com", "1234", "123")]
        [InlineData("Guilherme", "", "1234", "1234")]
        [InlineData("Guilherme", "guilherme@email.com", "", "1234")]
        public void DadoInfoInvalidasDeveContinuarNaHome(string nome, string email, string senha, string confirmSenha)
        {
            //Arrange
            registroPO.VisitarUrlBase();
            //Act - Efeturar o registro
            registroPO.PreencheFormularioNovoUsuario(nome, email, senha, confirmSenha);
            registroPO.SubmeteFormuarioCadastroUsuario();
            //Assert - Devo ser direcionado para a página de agradecimento
            Assert.Contains("Leilões Online", driver.Title);
        }

        [Fact]
        public void DadoNomeEmBrancoDeveMostrarMensagemDeErro()
        {
            //Arrange
            registroPO.VisitarUrlBase();
            //Act
            registroPO.SubmeteFormuarioCadastroUsuario();
            //Assert
            var elemento = registroPO.MensagemErro;
            Assert.Equal("The Nome field is required.", elemento);
        }
    }
}
