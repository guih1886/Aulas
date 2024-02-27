using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
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

            public bool NaoTemPai { get; set; }

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
                if (this.NaoTemPai == false)
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
