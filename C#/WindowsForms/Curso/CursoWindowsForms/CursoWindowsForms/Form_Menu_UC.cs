using CursoWindowsForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Form_Menu_UC : Form
    {
        int controleDM = 0;
        public Form_Menu_UC()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleDM++;
            Form_DesmonstracaoKey_UC u = new Form_DesmonstracaoKey_UC();
            TabPage tb = new TabPage();
            tb.Name = "Demonstração Key" + controleDM;
            tb.Text = "Demonstração Key" + controleDM;
            tb.ImageIndex = 1;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
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

        private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tuc_Aplicacao.SelectedTab != null) Tuc_Aplicacao.TabPages.Remove(Tuc_Aplicacao.SelectedTab);
        }
    }
}
