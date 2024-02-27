using CursoWindowsFormsBiblioteca.Classes;
using System;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string Diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string diretorio, string arquivo)
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
                mensagem = "Arquivo não pode ser criado \n " + error.Message;
                throw new Exception("Arquivo não pode ser criado \n " + error.Message);
            }
        }
    }
}
