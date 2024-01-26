using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos
{
    public class LeitorDeArquivoCsv : ILeitorDeArquivos
    {
        private string caminhoArquivo;

        public LeitorDeArquivoCsv(string? caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        public virtual IEnumerable<Pet> RealizaLeitura()
        {
            List<Pet> listaDePet = new List<Pet>();
            if (string.IsNullOrEmpty(caminhoArquivo))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                while (!sr.EndOfStream)
                {
                    // separa linha usando ponto e vírgula
                    string[] propriedades = sr.ReadLine().Split(';');
                    // cria objeto Pet a partir da separação
                    Pet pet = new Pet(Guid.Parse(propriedades[0]),
                      propriedades[1],
                      int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro
                     );
                    listaDePet.Add(pet);
                }
            }
            return listaDePet;
        }
    }
}
