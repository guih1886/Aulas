using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_DesmostracaoKey : Form
    {
        public Form_DesmostracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText($"Tecla: {e.KeyCode}" + "\r\n");
            Txt_Msg.AppendText("\t" + $"Código: {(int)e.KeyCode}" + "\r\n");
            Txt_Msg.AppendText("\t" + $"Nome: {e.KeyData}" + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Txt_Msg.Text = string.Empty;
            Txt_Input.Text = string.Empty;
            Lbl_Lower.Text = string.Empty; 
            Lbl_Upper.Text = string.Empty;
            Txt_Input.Focus();
        }
    }
}
