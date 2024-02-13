using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_ValidaSenha : Form
    {
        public ChecaForcaSenha Senha { get; set; }
        public Form_ValidaSenha()
        {
            InitializeComponent();
            Senha = new ChecaForcaSenha();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = string.Empty;
            Lbl_Resultado.Text = string.Empty;
            Txt_Senha.Focus();
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            string resultado = Senha.GetForcaDaSenha(Txt_Senha.Text).ToString();
            if (resultado.Equals("Inaceitavel")) Lbl_Resultado.ForeColor = Color.Red;
            if (resultado.Equals("Aceitavel")) Lbl_Resultado.ForeColor = Color.Blue;
            if (resultado.Equals("Forte") || resultado.Equals("Segura")) Lbl_Resultado.ForeColor = Color.Green;
            Lbl_Resultado.Text = resultado;
        }

        private void Btn_MostrarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            Txt_Senha.PasswordChar = '\0';
        }

        private void Btn_MostrarSenha_MouseLeave(object sender, EventArgs e)
        {
            Txt_Senha.PasswordChar = char.Parse("*");
        }
    }
}
