using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Common
{
    public class LeitorDeBoleto
    {
        public List<Boleto> LerBoletos(string caminhoArquivo)
        {

            // montar lista de boletos

            List<Boleto> boletos = new();

            // ler arquivo de boletos

            var reader = new StreamReader(caminhoArquivo);

            string linha = reader.ReadLine();

            // ler cabeçalho do arquivo CSV

            string[] cabecalho = linha.Split(',');

            // para cada linha do arquivo CSV
            // ler dados

            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();

                string[] dados = linha.Split(",");

                Boleto boleto = MapearTextoParaBoleto<Boleto>(cabecalho, dados);

                boletos.Add(boleto);

            }
            // carregar objeto Boleto
            // adicionar boleto à lista

            // retornar lista de boletos
            return boletos;
        }

        private T MapearTextoParaBoleto<T>(string[] nomesPropriedades, string[] valoresPropriedades)
        {
            T instancia = Activator.CreateInstance<T>();

            for (int i = 0; i < nomesPropriedades.Length; i++)
            {
                //Obtém a propriedade atraves do nome
                string nomePropriedade = nomesPropriedades[i];
                PropertyInfo propertyInfo = instancia.GetType().GetProperty(nomePropriedade);

                //Verifica se a propriedade foi encontrada
                if (propertyInfo != null)
                {
                    //Obtem o tipo da propriedade
                    Type type = propertyInfo.PropertyType;
                    //Obtem o valor da propriedade
                    string valor = valoresPropriedades[i];
                    //Converte o valor para o tipo correto
                    object valorConvertido = Convert.ChangeType(valor, type);

                    //Guarda o valor da propriedade
                    propertyInfo.SetValue(instancia, valorConvertido);
                }
            }
            return instancia;
        }
    }
}
