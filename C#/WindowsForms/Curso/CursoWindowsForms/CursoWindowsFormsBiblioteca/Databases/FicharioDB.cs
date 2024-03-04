using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDB connection;

        public FicharioDB(string tabela)
        {
            status = true;
            try
            {
                connection = new LocalDB();
                this.tabela = tabela;
                mensagem = "Conexão com a tabela criada com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                throw new Exception("Erro ao conectar com o banco de dados.\n " + error.Message);
            }
        }

        public string Buscar(string id)
        {
            status = true;
            try
            {
                string comando = $"SELECT * from {tabela} WHERE id = {id}";
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
            List<string> lista = new List<string>();
            status = true;
            try
            {
                string comando = $"SELECT * FROM {tabela}";
                DataTable retorno = connection.SQLQuery(comando);
                for (int i = 0; i < retorno.Rows.Count - 1; i++)
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
                string comando = $"DELETE FROM {tabela} WHERE id = {id}";
                connection.SQLComand(comando);
                mensagem = $"{tabela} excluido com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Não foi possível excluir o {tabela}. \n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Incluir(string id, string arquivo)
        {
            status = true;
            try
            {
                string comando = $"INSERT INTO {tabela} (ID, JSON) VALUES ({id},{arquivo})";
                connection.SQLComand(comando);
                mensagem = $"{tabela} incluido com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Não foi possível incluir o {tabela}.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Atualizar(string id, string arquivo)
        {
            status = true;
            try
            {
                string comando = $"UPDATE {tabela} SET JSON = {arquivo} WHERE id = {id}";
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
