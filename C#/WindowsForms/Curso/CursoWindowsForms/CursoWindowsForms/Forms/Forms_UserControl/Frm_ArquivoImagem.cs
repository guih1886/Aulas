using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms.Forms_UserControl
{
    public partial class Frm_ArquivoImagem : UserControl
    {
        public Frm_ArquivoImagem(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Cor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = colorDialog.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, System.EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = fontDialog.Font;
            }
        }
    }
}
