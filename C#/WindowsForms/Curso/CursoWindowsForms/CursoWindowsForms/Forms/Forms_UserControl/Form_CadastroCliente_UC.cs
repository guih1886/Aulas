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
            Lbl_Genero.Text = "Genero";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
        }
    }
}
