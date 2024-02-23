using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms.Forms_UserControl
{
    public partial class Form_CadastroCliente_UC : UserControl
    {
        public Form_CadastroCliente_UC()
        {
            InitializeComponent();
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
