using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms
{
    public partial class Form_MouseEventos : Form
    {
        public Form_MouseEventos()
        {
            InitializeComponent();
        }

        private void Btn_Mouse_MouseEnter(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse Enter";
        }

        private void Btn_Mouse_MouseLeave(object sender, EventArgs e)
        {
            Btn_Mouse.Text = "Mouse Leave";
        }

        private void Btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            
            Btn_Mouse.BackColor = Color.Red;
        }

        private void Btn_Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_Mouse.BackColor = Color.White;
        }
    }
}
