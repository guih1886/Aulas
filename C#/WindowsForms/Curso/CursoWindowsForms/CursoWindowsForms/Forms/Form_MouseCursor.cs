using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Forms
{
    public partial class Form_MouseCursor : Form
    {
        public Form_MouseCursor()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Lbl_X.Text = e.X.ToString();
            Lbl_Y.Text = e.Y.ToString();

            if (e.Button == MouseButtons.Right) MessageBox.Show("Direita");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Cursor = Cursors.WaitCursor;
        //    Thread.Sleep(TimeSpan.FromSeconds(10));
        //    this.Cursor = Cursors.Default;
        //}
    }
}
