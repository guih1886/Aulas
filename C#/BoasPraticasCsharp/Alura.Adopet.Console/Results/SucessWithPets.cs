using Alura.Adopet.Console.Modelos;
using FluentResults;

namespace Alura.Adopet.Console.Results
{
    public class SucessWithPets : Success
    {
        public IEnumerable<Pet> Data { get; }
        public string Mensagem;

        public SucessWithPets(IEnumerable<Pet> data, string msg)
        {
            Data = data;
            Mensagem = msg;
        }
    }
}