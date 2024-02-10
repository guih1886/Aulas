using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_HelloWorld : Form
    {
        public Form_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_ConteudoLabel.Text != string.Empty)
            {
                this.lbl_Titulo.Text = Txt_ConteudoLabel.Text;
            }
        }

        private void Btn_AbrirKey_Click(object sender, EventArgs e)
        {
            Form form = new Form_DesmostracaoKey();
            form.Show();
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Form form = new Form_ValidaSenha();
            form.Show();
        }
    }
}
