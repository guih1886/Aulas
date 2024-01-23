using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    public class LeitorDeArquivo
    {
        private string caminhoArquivo;

        public LeitorDeArquivo(string? caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        public virtual List<Pet> RealizaLeitura()
        {
            List<Pet> listaDePet = new List<Pet>();
            if (string.IsNullOrEmpty(this.caminhoArquivo))
            {
                return null;
            }
            using (StreamReader sr = new StreamReader(this.caminhoArquivo))
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
