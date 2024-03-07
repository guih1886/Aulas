using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioSqlServer
    {
        public string mensagem;
        public bool status = true;
        public string tabela = "Clientes";
        public SQLServer connection;

        public FicharioSqlServer()
        {
            status = true;
            try
            {
                connection = new SQLServer();
                //this.tabela = tabela;
                mensagem = "Conexão com a tabela criada com sucesso.";
            }
            catch (Exception)
            {
                status = false;
                mensagem = "Erro ao conectar com o banco de dados.";
                throw new Exception(mensagem);
            }
        }

        public string Buscar(string id)
        {
            status = true;
            try
            {
                string comando = $"SELECT [Id],[Json] FROM [dbo].[{tabela}] WHERE [Id] = {id}";
                DataTable retorno = connection.SQLQuery(comando);
                mensagem = $"{tabela} foi resgatado foi um sucesso.";
                return retorno.Rows[0]["JSON"].ToString();
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Erro ao buscar conteudo do id.\n " + error.Message;
                return "";
            }

        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> lista = new List<string>();
            try
            {
                string comando = "SELECT * FROM [dbo].[" + tabela + "]";
                DataTable retorno = connection.SQLQuery(comando);
                for (int i = 0; i < retorno.Rows.Count; i++)
                {
                    lista.Add(retorno.Rows[i]["JSON"].ToString());
                }
                mensagem = $"{tabela} recuperados com sucesso.";
                return lista;
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Não foi possível buscar {tabela}.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Excluir(string id)
        {
            status = true;
            try
            {
                string comando = "DELETE FROM [dbo].[Clientes] WHERE Id = " + id + "";
                connection.SQLComand(comando);
                mensagem = $"{tabela} excluido com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = $"Não foi possível excluir o {tabela}. \n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Incluir(string id, string arquivo)
        {
            status = true;
            try
            {
                string comando = $"INSERT INTO {tabela} ([Id], [Json]) VALUES ('" + id + "','" + arquivo + "')";
                connection.SQLComand(comando);
                mensagem = $"{tabela} incluido com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = $"Não foi possível incluir o {tabela}.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Atualizar(string id, string arquivo)
        {
            status = true;
            try
            {
                string comando = $"UPDATE {tabela} SET JSON = '" + arquivo + "' WHERE id = '" + id + "'";
                connection.SQLComand(comando);
                mensagem = $"{tabela} atualizado com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = $"Não foi possível atualizar o {tabela}.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

    }
}
