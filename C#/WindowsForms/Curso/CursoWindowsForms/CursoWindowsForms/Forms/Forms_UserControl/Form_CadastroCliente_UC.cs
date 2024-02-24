using CursoWindowsFormsBiblioteca.Classes;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms.Forms_UserControl
{
    public partial class Form_CadastroCliente_UC : UserControl
    {
        public Form_CadastroCliente_UC()
        {
            InitializeComponent();
            Txt_NumeroCliente.Focus();
            Grp_Codigo.Text = "Código do Cliente";
            Grp_DadosPessoais.Text = "Dados pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros dados";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_Cidade.Text = "Cidade";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Ckb_TemPai.Text = "Pai desconhecido";

            Cmb_Estados.Items.AddRange(new object[] {
                             "Acre",
  "Alagoas",
  "Amapá",
  "Amazonas",
  "Bahia",
  "Ceará",
  "Distrito Federal",
  "Espirito Santo",
  "Goiás",
  "Maranhão",
  "Mato Grosso do Sul",
  "Mato Grosso",
  "Minas Gerais",
  "Pará",
  "Paraíba",
  "Paraná",
  "Pernambuco",
  "Piauí",
  "Rio de Janeiro",
  "Rio Grande do Norte",
  "Rio Grande do Sul",
  "Rondônia",
  "Roraima",
  "Santa Catarina",
  "São Paulo",
  "Sergipe",
  "Tocantins",
                        });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_TemPai.Checked)
            {
                Txt_NomePai.Text = "Pai desconhecido.";
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Text = "";
                Txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraForm();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
            }
            catch (ValidationException err)
            {
                throw new ValidationException(err.Message);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private Cliente.Unit LeituraForm()
        {
            Cliente.Unit cliente = new Cliente.Unit();
            cliente.Id = Txt_NumeroCliente.Text;
            cliente.CPF = Msk_CPF.Text.Replace(",", "").Replace("-", "").Trim();
            cliente.Nome = Txt_NomeCliente.Text;
            cliente.NomeMae = Txt_NomeMae.Text;
            cliente.NomePai = Txt_NomePai.Text;
            cliente.NaoTemPai = false;
            if (Ckb_TemPai.Checked) cliente.NaoTemPai = true;
            if (Rdb_Masculino.Checked) cliente.Genero = 0;
            if (Rdb_Feminino.Checked) cliente.Genero = 1;
            if (Rdb_Indefinido.Checked) cliente.Genero = 2;
            cliente.Cep = Txt_CEP.Text;
            cliente.Logradouro = Txt_Logradouro.Text;
            cliente.Bairro = Txt_Bairro.Text;
            cliente.Cidade = Txt_Cidade.Text;
            cliente.Complemento = Txt_Complemento.Text;
            cliente.Estado = Cmb_Estados.SelectedIndex != -1 ? Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString() : "";
            cliente.Telefone = Txt_Telefone.Text;
            cliente.Profissao = Txt_Profissao.Text;
            cliente.RendaFamiliar = (Information.IsNumeric(Txt_RendaFamiliar.Text) && double.Parse(Txt_RendaFamiliar.Text) > 0) ?
                cliente.RendaFamiliar = double.Parse(Txt_RendaFamiliar.Text) :
                cliente.RendaFamiliar = 0;
            return cliente;
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void limparToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void apagaToolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
