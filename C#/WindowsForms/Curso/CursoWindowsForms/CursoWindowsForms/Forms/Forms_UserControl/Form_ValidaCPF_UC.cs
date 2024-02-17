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
    public partial class Form_ValidaCPF_UC : UserControl
    {
        public Form_ValidaCPF_UC()
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
