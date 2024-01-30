using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public abstract class LeitorDeArquivoCsv<T> : ILeitorDeArquivos<T>
    {
        private string? caminhoArquivo;

        public LeitorDeArquivoCsv(string? caminhoArquivo)
        {
            this.caminhoArquivo = caminhoArquivo;
        }

        public virtual IEnumerable<T> RealizaLeitura()
        {
            List<T> listaDePet = new List<T>();
            if (string.IsNullOrEmpty(caminhoArquivo))
            {
                return null!;
            }
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                while (!sr.EndOfStream)
                {
                    string? linha = sr.ReadLine();
                    if (linha is not null)
                    {
                        var objeto = CriarDaLinhaCsv(linha);
                        listaDePet.Add(objeto);

                    }
                }
            }
            return listaDePet;
        }
        public abstract T CriarDaLinhaCsv(string linha);
    }
}
