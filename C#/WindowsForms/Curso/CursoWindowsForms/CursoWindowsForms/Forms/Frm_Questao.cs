using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem, string titulo, string mensagem)
        {
            InitializeComponent();
            Image imagem = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = imagem;
            Lbl_Questao.Text = mensagem;
            Frm_Questao.ActiveForm.Text = titulo;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
