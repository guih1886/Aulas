using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_Mascara : Form
    {
        public Form_Mascara()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "00:00";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "00000-000";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "$0,000.00";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "(00) 00000-0000";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            Lbl_Conteudo.Text = string.Empty;
            Msk_TextBox.Mask = "000000";
            Lbl_MmascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Clear();
            Msk_TextBox.Focus();
        }
    }
}
