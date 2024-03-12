using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.Databases;
using System.Data;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            private FicharioSqlServer fichario;
            private SQLServer db;

            public Unit()
            {
                fichario = new FicharioSqlServer();
                db = new SQLServer();
            }

            #region "Propriedades"
            [Required(ErrorMessage = "O código do cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O Id só pode ser números.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "O código do cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
            [StringLength(50, MinimumLength = 6, ErrorMessage = "O nome do cliente deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O nome da mãe do cliente é obrigatório.")]
            [StringLength(50, MinimumLength = 6, ErrorMessage = "O nome da mãe do cliente deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public string NomePai { get; set; }

            public int NaoTemPai { get; set; }

            [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O CPF só pode ser números.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF do cliente deve ter 11 dígitos.")]
            public string CPF { get; set; }

            [Required(ErrorMessage = "O genero do cliente é obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "O cep do cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O Cep só pode ser números.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "O logradouro é obrigatório.")]
            [StringLength(100, MinimumLength = 6, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            public string Complemento { get; set; }

            [Required(ErrorMessage = "O bairro é obrigatório.")]
            [StringLength(50, MinimumLength = 6, ErrorMessage = "O bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "A cidade é obrigatório.")]
            [StringLength(50, MinimumLength = 6, ErrorMessage = "O cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O estado é obrigatório.")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "O telefone do cliente é obrigatório.")]
            [RegularExpression("([0-9]*)", ErrorMessage = "O telefone só pode ser números.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "A renda familiar do cliente é obrigatório.")]
            [Range(0, double.MaxValue, ErrorMessage = "O renda familiar só pode ser números.")]
            public double RendaFamiliar { get; set; }
            #endregion

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new Exception(sbrErrors.ToString());
                }
                if (!Cls_Uteis.Validar(this.CPF)) throw new Exception("CPF inválido.");
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais.");
                }
                if (this.NaoTemPai == 1)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Marque o flag de 'Pai Desconhecido'");
                    }
                }
                if (!Cls_Uteis.Validar(this.CPF.Replace(",", "").Replace(".", "").Replace("-", "").Trim()))
                {
                    throw new Exception("CPF inválido!");
                }
            }

            #region "CRUD Fichario"

            public void IncluirFichario()
            {
                ValidaClasse();
                ValidaComplemento();
                string clienteJson = SerializeClassUnit(this);
                if (fichario.status)
                {
                    fichario.Incluir(Id, clienteJson);
                    if (!fichario.status)
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            public Unit BuscarFichario(string id)
            {
                if (fichario.status)
                {
                    string clienteJson = fichario.Buscar(id);
                    if (clienteJson != "")
                    {
                        Unit cliente = DesSerializeClassUnit(clienteJson);
                        return cliente;
                    }
                    else
                    {
                        throw new Exception(fichario.mensagem);
                    }
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            public void AlterarFichario()
            {
                ValidaClasse();
                ValidaComplemento();
                var busca = fichario.Buscar(Id);
                if (busca != "")
                {
                    string clienteJson = SerializeClassUnit(this);
                    fichario.Atualizar(Id, clienteJson);
                    MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Cliente não encontrado.");
                }
            }

            public void ExcluirFichario()
            {
                if (fichario.status)
                {
                    fichario.Excluir(Id);
                    MessageBox.Show(fichario.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Fichario não encontrado.");
                }
            }

            public List<string> ListaFichario()
            {
                if (fichario.status)
                {
                    List<string> lista = fichario.BuscarTodos();
                    return lista;
                }
                else
                {
                    throw new Exception(fichario.mensagem);
                }
            }

            #endregion

            #region "CRUD Clientes Sql Server"

            public string ToInsert()
            {
                string SQL = $@"INSERT INTO Clientes2
                                (Id,Nome,NomeMae,NomePai,
                                NaoTemPai,CPF,Genero,Cep,
                                Logradouro,Complemento,Bairro,
                                Cidade,Estado,Telefone,Profissao,RendaFamiliar)
                                VALUES ('{Id}','{Nome}','{NomeMae}','{NomePai}',{NaoTemPai},'{CPF}',
                           {Genero},'{Cep}','{Logradouro}','{Complemento}','{Bairro}',
                           '{Cidade}','{Estado}','{Telefone}','{Profissao}',{RendaFamiliar})";
                return SQL;
            }

            public string ToUpdate(string id)
            {
                string SQL = $@"UPDATE Clientes2 
                                SET Id = '{id}',
                                    Nome = '{Nome}',
                                    NomeMae = '{NomeMae}',
                                    NomePai = '{NomePai}',
                                    NaoTemPai = {NaoTemPai},
                                    CPF = '{CPF}',
                                    Genero = {Genero},
                                    Cep = '{Cep}',
                                    Logradouro = '{Logradouro}',
                                    Complemento = '{Complemento}',
                                    Bairro = '{Bairro}',
                                    Cidade = '{Cidade}',
                                    Estado = '{Estado}',
                                    Telefone = '{Telefone}',
                                    Profissao = '{Profissao}',
                                    RendaFamiliar = {RendaFamiliar}
                                  WHERE Id = '{id}';";
                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit cliente = new Unit();
                cliente.Id = dr["Id"].ToString();
                cliente.Nome = dr["Nome"].ToString();
                cliente.NomeMae = dr["NomeMae"].ToString();
                cliente.NomePai = dr["NomePai"].ToString();
                cliente.NaoTemPai = Convert.ToInt32(dr["NaoTemPai"]);
                cliente.CPF = dr["CPF"].ToString();
                cliente.Genero = Convert.ToInt32(dr["Genero"]);
                cliente.Cep = dr["Cep"].ToString();
                cliente.Logradouro = dr["Logradouro"].ToString();
                cliente.Complemento = dr["Complemento"].ToString();
                cliente.Bairro = dr["Bairro"].ToString();
                cliente.Cidade = dr["Cidade"].ToString();
                cliente.Estado = dr["Estado"].ToString();
                cliente.Telefone = dr["Telefone"].ToString();
                cliente.Profissao = dr["Profissao"].ToString();
                cliente.RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"]);
                return cliente;
            }

            public void IncluirFicharioSql()
            {
                try
                {
                    string sql = ToInsert();
                    db.SQLComand(sql);
                }
                catch (Exception erro)
                {
                    throw new Exception("Erro ao incluir o cliente.\n" + erro);
                }
            }

            public Unit BuscarFicharioSql(string id)
            {
                try
                {
                    string sql = $"SELECT * FROM Clientes2 WHERE Id = {id}";
                    DataTable result = db.SQLQuery(sql);
                    if (result.Rows.Count != 0)
                    {
                        Unit cliente = DataRowToUnit(result.Rows[0]);
                        return cliente;
                    }
                    throw new Exception("Cliente com o Id não encontrado.");
                }
                catch (Exception error)
                {
                    throw new Exception("Erro ao buscar o cliente.\n" + error.Message);
                }
            }

            public void AlterarFicharioSql(string id)
            {
                try
                {
                    string sql = $"SELECT * FROM Clientes2 WHERE Id = {id}";
                    DataTable result = db.SQLQuery(sql);
                    if (result.Rows.Count != 0)
                    {
                        sql = ToUpdate(id);
                        db.SQLComand(sql);
                    }
                    else
                    {
                        throw new Exception("Cliente com o Id não encontrado.");
                    }
                }
                catch (Exception error)
                {
                    throw new Exception("Erro ao alterar o cliente.\n" + error.Message);
                }
            }

            public void ExcluirFicharioSql(string id)
            {
                try
                {
                    string sql = $"SELECT * FROM Clientes2 WHERE Id = {id}";
                    DataTable result = db.SQLQuery(sql);
                    if (result.Rows.Count != 0)
                    {
                        sql = $"DELETE FROM Clientes2 WHERE Id = {id}";
                        db.SQLComand(sql);
                    }
                    else
                    {
                        throw new Exception("Cliente com o Id não encontrado.");
                    }
                }
                catch (Exception error)
                {
                    throw new Exception("Erro ao excluir o cliente.\n" + error.Message);
                }
            }

            public List<Unit> BuscarTodosFichariosSql()
            {
                try
                {
                    string sql = $"SELECT * FROM Clientes2";
                    DataTable result = db.SQLQuery(sql);
                    List<Unit> clientes = new List<Unit>();
                    if (result.Rows.Count != 0)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            clientes.Add(DataRowToUnit(row));
                        }
                        return clientes;
                    }
                    return clientes;
                }
                catch (Exception error)
                {
                    throw new Exception("Erro ao buscar os clientes.\n" + error.Message);
                }
            }

            #endregion

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializeClassUnit(string json)
        {
            return JsonConvert.DeserializeObject<Unit>(json);
        }

        public static string SerializeClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

    }
}
