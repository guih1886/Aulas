using CursoWindowsFormsBiblioteca;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_ValidaCPF : Form
    {
        public Form_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            this.Lbl_Resultado.Text = string.Empty;
            Msk_CPF.Clear();
            Msk_CPF.Focus();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            Msk_CPF.Focus();
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Validar(Msk_CPF.Text);
            if (validaCPF)
            {
                Lbl_Resultado.Text = "CPF válido.";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF inválido.";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
