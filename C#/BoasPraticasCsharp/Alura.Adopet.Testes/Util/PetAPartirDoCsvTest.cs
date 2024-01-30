using Alura.Adopet.Console.Modelos;
using Xunit;

namespace Alura.Adopet.Testes.Util
{
    public class PetAPartirDoCsvTest
    {
        [Fact]
        public void QuandoStringForValidaDeveRetornarUmPet()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
            //Act
            Pet pet = linha.ConverteDoTexto();
            //Assert
            Assert.NotNull(pet);
        }

        [Fact]
        public void DeveRetornarExcecaoQuandoALinhaForNull()
        {
            //Arrange
            string? linha = null;
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => linha!.ConverteDoTexto());
        }

        [Fact]
        public void DeveRetornarExcecaoQuandoALinhaForVazia()
        {
            //Arrange
            string? linha = "";
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void DeveRetornarErroQuandoOsCamposForemInsuficientes()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão";
            //Act
            //Assert
            Assert.Throws<Exception>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void VerificaSeOGuidEInvalido()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-sda65e98sf98sa32e;Lima Limão;1";
            //Act
            //Assert
            Assert.Throws<Exception>(() => linha.ConverteDoTexto());
        }

        [Fact]
        public void VerificaSeOTipoEInvalido()
        {
            //Arrange
            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;3";
            //Act
            //Assert
            Assert.Throws<Exception>(() => linha.ConverteDoTexto());
        }
    }
}
