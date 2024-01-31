using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Results;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "import",
        documentacao: "adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
    public class Import : IComando, IDepoisDaExecucao
    {
        private readonly IApiService<Pet> clientPet;
        private readonly ILeitorDeArquivos<Pet> leitor;

        public Import(IApiService<Pet> clientPet, ILeitorDeArquivos<Pet> leitor)
        {
            this.clientPet = clientPet;
            this.leitor = leitor;
        }

        public event Action<Result>? DepoisDaExecucao;

        public async Task<Result> ExecutarAsync()
        {
            return await ImportacaoArquivoPetAsync();
        }

        private async Task<Result> ImportacaoArquivoPetAsync()
        {
            try
            {
                IEnumerable<Pet> listaDePet = leitor.RealizaLeitura();
                foreach (var pet in listaDePet)
                {
                    try
                    {
                        await clientPet.CreateAsync(pet);
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
                var resultado = Result.Ok().WithSuccess(new SuccessWithPets(listaDePet, "Importação realizada com sucesso."));
                DepoisDaExecucao?.Invoke(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return Result.Fail(new Error(e.Message).CausedBy(e));
            }
        }
    }
}
