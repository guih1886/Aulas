using System;
using System.Data;
using System.Data.SqlClient;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class LocalDB
    {
        public string connection;
        public SqlConnection connectionDB;

        public LocalDB()
        {
            try
            {
                this.connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilh\\Documents\\GitHub\\Aulas\\C#\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsFormsBiblioteca\\Databases\\Fichario.mdf;Integrated Security=True";
                connectionDB = new SqlConnection(connection);
                connectionDB.Open();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public string SQLComand(string comand)
        {
            try
            {
                var c = new SqlCommand(comand, connectionDB);
                c.CommandTimeout = 0;

                var reader = c.ExecuteReader();
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
                SqlCommand c = new SqlCommand(query, connectionDB);
                SqlDataReader reader = c.ExecuteReader();
                dt.Load(reader);
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
    }
}
