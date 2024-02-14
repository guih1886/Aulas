using CursoWindowsForms.Forms;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_DesmostracaoKey();
            form.MdiParent = this;
            form.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Mascara();
            form.MdiParent = this;
            form.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_ValidaCPF();
            form.MdiParent = this;
            form.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_ValidaCPF2();
            form.MdiParent = this;
            form.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_ValidaSenha();
            form.MdiParent = this;
            form.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form_Sobre();
            form.MdiParent = this;
            form.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
