using CursoWindowsFormsBiblioteca;
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
    public partial class Form_ValidaCPF2_UC : UserControl
    {
        public Form_ValidaCPF2_UC()
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

            DialogResult result = new Frm_Questao("question", "Confirmação de Validação", "Deseja validar o CPF?").ShowDialog();
            if (result == DialogResult.Yes)
            {
                Msk_CPF.Focus();
                bool validaCPF = false;
                validaCPF = Cls_Uteis.Validar(Msk_CPF.Text);
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

        private void Form_ValidaCPF2_UC_Load(object sender, EventArgs e)
        {
            Msk_CPF.Focus();
        }
    }
}
