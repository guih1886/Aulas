using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class SQLServer
    {
        public string connection;
        public SqlConnection connectionDB;

        public SQLServer()
        {
            try
            {
                connection = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                connectionDB = new SqlConnection(connection);
            }
            catch (Exception error)
            {
                throw new Exception("Erro ao conectar com o banco de dados.\n" + error.Message);
            }
        }

        public string SQLComand(string comand)
        {
            try
            {
                connectionDB.Open();
                var c = new SqlCommand(comand, connectionDB);
                c.CommandTimeout = 0;

                var reader = c.ExecuteReader();
                connectionDB.Close();
                return "";
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataTable SQLQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                connectionDB.Open();
                SqlCommand c = new SqlCommand(query, connectionDB);
                SqlDataReader reader = c.ExecuteReader();
                dt.Load(reader);
                connectionDB.Close();
                return dt;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void Close()
        {
            connectionDB.Close();
        }

        public void Open()
        {
            connectionDB.Open();
        }
    }
}
