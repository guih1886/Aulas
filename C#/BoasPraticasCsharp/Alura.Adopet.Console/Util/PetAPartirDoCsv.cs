using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Testes
{
    public static class PetAPartirDoCsv
    {

        public static Pet ConverteDoTexto(this string linha)
        {
            //Verifica se a linha é nula ou vazia
            if (string.IsNullOrEmpty(linha))
            {
                throw new ArgumentNullException("Linha nula ou vazia.");
            }
            // separa linha usando ponto e vírgula
            string[] propriedades = linha.Split(';');
            //Verifica se os campos são suficientes
            if (propriedades.Length != 3)
            {
                throw new Exception("Campos insuficientes.");
            }
            // cria objeto Pet a partir da separação
            Guid id;
            string nome = propriedades[1];
            int tipo = int.Parse(propriedades[2]);
            if (Guid.TryParse(propriedades[0], out Guid result))
            {
                id = Guid.Parse(propriedades[0]);
                if (tipo != 1 && tipo != 2)
                {
                    throw new Exception("Tipo inválido.");
                }
                return new Pet(id, propriedades[1], int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro);
            }
            else
            {
                throw new Exception("Guid inválido.");
            }

        }
    }
}