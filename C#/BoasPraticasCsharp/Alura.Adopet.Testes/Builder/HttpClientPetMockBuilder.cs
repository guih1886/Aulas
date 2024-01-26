﻿using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Arquivos;
using Moq;

namespace Alura.Adopet.Testes.Builder
{
    public static class HttpClientPetMockBuilder
    {
        public static Mock<HttpClientPet> GetMock()
        {
            var httpClientPet = new Mock<HttpClientPet>(MockBehavior.Default,
                It.IsAny<HttpClient>());
            return httpClientPet;
        }

        public static Mock<HttpClientPet> GetMockList(List<Pet> lista)
        {
            var httpClientPet = new Mock<HttpClientPet>(MockBehavior.Default,
                It.IsAny<HttpClient>());
            httpClientPet.Setup(_ => _.ListPetsAsync()).ReturnsAsync(lista);
            return httpClientPet;
        }
    }
}
