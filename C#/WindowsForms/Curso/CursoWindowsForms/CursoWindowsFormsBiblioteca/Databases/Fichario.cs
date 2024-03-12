using CursoWindowsFormsBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string Diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string diretorio)
        {
            status = true;
            try
            {
                if (!Directory.Exists(diretorio)) Directory.CreateDirectory(diretorio);
                Diretorio = diretorio;
                mensagem = "Conexão com o fichario criado com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Conexão com o fichario não pode ser criada \n " + error.Message;
            }
        }

        public void Atualizar(string id, string arquivo)
        {
            status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    File.Delete($"{Diretorio}\\{id}.json");
                }

                File.WriteAllText($"{Diretorio}\\{id}.json", arquivo);
                mensagem = "Atualização efetuada com sucesso.";
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Não foi possível atualizar o cliente.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public string Buscar(string id)
        {
            status = true;
            try
            {
                if (!File.Exists($"{Diretorio}\\{id}.json"))
                {
                    status = false;
                    mensagem = "Id não encontrado.";
                    return "";
                }
                else
                {
                    status = true;
                    mensagem = "Id encontrado com sucesso.";
                    string conteudo = File.ReadAllText($"{Diretorio}\\{id}.json");
                    return conteudo;
                }
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
            List<string> list = new List<string>();
            try
            {
                string[] arquivos = Directory.GetFiles(Diretorio, "*.json");
                foreach (string arquivo in arquivos)
                {
                    string conteudo = File.ReadAllText(arquivo);
                    list.Add(conteudo);
                }
                return list;
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Erro ao buscar clientes.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Excluir(string id)
        {
            status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    File.Delete($"{Diretorio}\\{id}.json");
                    mensagem = "Exclusão efetuada com sucesso.";
                }
                else
                {
                    mensagem = "Cliente não encontrado.";
                }
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Arquivo não pode ser criado \n " + error.Message;
                throw new Exception(mensagem);
            }
        }

        public void Incluir(string id, string arquivo)
        {
            status = true;
            try
            {
                if (File.Exists($"{Diretorio}\\{id}.json"))
                {
                    status = false;
                    mensagem = $"Arquivo com o id {id} já existe";
                }
                else
                {
                    File.WriteAllText($"{Diretorio}\\{id}.json", arquivo);
                    mensagem = "Inclusão efetuada com sucesso.";
                }
            }
            catch (Exception error)
            {
                status = false;
                mensagem = "Não foi possível incluir o cliente.\n " + error.Message;
                throw new Exception(mensagem);
            }
        }
    }
}
