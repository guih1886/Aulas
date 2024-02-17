using CursoWindowsFormsBiblioteca;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            Lbl_Login.Text = "Usuário";
            Lbl_Password.Text = "Senha";
            Btn_OK.Text = "OK";
            Btn_Cancel.Text = "Cancel";
            Txt_Password.UseSystemPasswordChar = true;
        }

        private void Btn_OK_Click(object sender, System.EventArgs e)
        {
            if (Cls_Uteis.ValidaSenhaLogin(Txt_Password.Text))
            {
                Form f = new Form_Menu_UC();
                f.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Login.Text = "";
                Txt_Password.Text = "";
                Txt_Login.Focus();
            }
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
