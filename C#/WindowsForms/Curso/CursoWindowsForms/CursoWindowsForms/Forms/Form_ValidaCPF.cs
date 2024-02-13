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

        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
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
            validaCPF = Valida(Msk_CPF.Text);
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
