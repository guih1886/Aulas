using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util.Util
{
    public class LeitorDeArquivo
    {
        public List<Pet> RealizaLeitura(string caminhoDoArquivoASerLido)
        {
            List<Pet> listaDePet = new List<Pet>();
            using (StreamReader sr = new StreamReader(caminhoDoArquivoASerLido))
            {
                while (!sr.EndOfStream)
                {
                    // separa linha usando ponto e vírgula
                    string[] propriedades = sr.ReadLine().Split(';');
                    // cria objeto Pet a partir da separação
                    Pet pet = new Pet(Guid.Parse(propriedades[0]),
                      propriedades[1],
                      TipoPet.Cachorro
                     );

                    System.Console.WriteLine(pet);
                    listaDePet.Add(pet);
                }
            }
            return listaDePet;
        }
    }
}
