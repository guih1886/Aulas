using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms
{
    public partial class Form_ValidaCPF2 : Form
    {
        public Form_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Msk_CPF.Clear();
            Msk_CPF.Focus();
        }

        private void Btn_Valida_Click(object sender, System.EventArgs e)
        {
            string conteudo = Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim();
            if (conteudo == string.Empty || conteudo.Length < 11)
            {
                MessageBox.Show("Você deve inserir um CPF completo.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Msk_CPF.Focus();
                return;
            }
            
            var result = MessageBox.Show("Deseja validar o cpf?", "Confirmação de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Msk_CPF.Focus();
                bool validaCPF = false;
                validaCPF = ValidaCPF.Validar(Msk_CPF.Text);
                if (validaCPF)
                {
                    MessageBox.Show("CPF válido.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF inválido.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Msk_CPF_TextChanged(object sender, System.EventArgs e)
        {
            string conteudo = Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim();
            if (conteudo.Length == 11)
            {
                Btn_Valida.Focus();
            }
        }
    }
}
