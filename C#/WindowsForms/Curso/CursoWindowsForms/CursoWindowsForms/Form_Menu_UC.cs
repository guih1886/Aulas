using CursoWindowsForms.Forms;
using CursoWindowsForms.Forms.Forms_UserControl;
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
        int controleMask = 0;
        int controleCPF = 0;
        int controleCPF2 = 0;
        int controleSenha = 0;
        int controleArquivoImagem = 0;
        int controleCadastroCliente = 0;
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
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Demonstração Key" + controleDM;
            tb.Text = $"Demonstração Key ({controleDM})";
            tb.ImageIndex = 1;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleMask++;
            Form_Mascara_UC u = new Form_Mascara_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Mascara" + controleMask;
            tb.Text = $"Mascara ({controleMask})";
            tb.ImageIndex = 2;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleCPF++;
            Form_ValidaCPF_UC u = new Form_ValidaCPF_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "CPF" + controleCPF;
            tb.Text = $"CPF ({controleCPF})";
            tb.ImageIndex = 3;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleCPF2++;
            Form_ValidaCPF2_UC u = new Form_ValidaCPF2_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "CPF2" + controleCPF2;
            tb.Text = $"CPF2 ({controleCPF2})";
            tb.ImageIndex = 4;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleSenha++;
            Form_ValidaSenha_UC u = new Form_ValidaSenha_UC();
            u.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Senha" + controleSenha;
            tb.Text = $"Senha ({controleSenha})";
            tb.ImageIndex = 4;
            tb.Controls.Add(u);
            Tuc_Aplicacao.TabPages.Add(tb);
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

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog db = new OpenFileDialog();
            db.Filter = "PNG|*.PNG";
            db.Title = "Escolha a imagem";

            if (db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = db.FileName;
                controleArquivoImagem++;
                Frm_ArquivoImagem u = new Frm_ArquivoImagem(nomeArquivoImagem);
                u.Dock = DockStyle.Fill;
                TabPage tb = new TabPage();
                tb.Name = "Arquivo Imagem" + controleArquivoImagem;
                tb.Text = $"Arquivo Imagem ({controleArquivoImagem})";
                tb.Controls.Add(u);
                Tuc_Aplicacao.TabPages.Add(tb);
            }
        }

        private void Tuc_Aplicacao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contexMenu = new ContextMenuStrip();

                var item1 = desenhaItemMenu("Fechar a aba", "DeleteTab");
                var item2 = desenhaItemMenu("Fechar todas à esquerda", "DeleteLeft");
                var item3 = desenhaItemMenu("Fechar todas à direita", "DeleteRight");
                var item4 = desenhaItemMenu("Fechar todas menos esta", "DeleteAll");

                contexMenu.Items.Add(item1);
                contexMenu.Items.Add(item2);
                contexMenu.Items.Add(item3);
                contexMenu.Items.Add(item4);


                item1.Click += new EventHandler(item1_Click);
                item2.Click += new EventHandler(item2_Click);
                item3.Click += new EventHandler(item3_Click);
                item4.Click += new EventHandler(item4_Click);

                contexMenu.Show(this, new Point(e.X, e.Y));
            }
        }
        private ToolStripMenuItem desenhaItemMenu(string text, string nomeImagem, params string[] dropdowns)
        {
            var itemMenu = new ToolStripMenuItem();
            itemMenu.Text = text;
            itemMenu.Image = (System.Drawing.Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            foreach (string dropdown in dropdowns)
            {
                if (dropdown != null)
                {
                    itemMenu.DropDownItems.Add(dropdown);
                }
            }
            return itemMenu;
        }

        private void item1_Click(object sender, EventArgs e)
        {
            if (Tuc_Aplicacao.SelectedTab != null) FechaAba(Tuc_Aplicacao.SelectedTab);
        }
        private void item2_Click(object sender, EventArgs e)
        {
            for (int i = Tuc_Aplicacao.SelectedIndex - 1; i >= 0; i--)
            {
                FechaAba(Tuc_Aplicacao.TabPages[i]);
            }
        }
        private void item3_Click(object sender, EventArgs e)
        {
            for (int i = Tuc_Aplicacao.TabCount - 1; i > Tuc_Aplicacao.SelectedIndex; i--)
            {
                FechaAba(Tuc_Aplicacao.TabPages[i]);
            }
        }
        private void item4_Click(object sender, EventArgs e)
        {
            for (int i = Tuc_Aplicacao.TabCount - 1; i >= 0; i--)
            {
                if (i != Tuc_Aplicacao.SelectedIndex)
                {
                    FechaAba(Tuc_Aplicacao.TabPages[i]);
                }
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleCadastroCliente++;
            if (controleCadastroCliente == 1)
            {
                Form_CadastroCliente_UC u = new Form_CadastroCliente_UC();
                u.Dock = DockStyle.Fill;        
                TabPage tb = new TabPage();
                tb.Name = "CadastroCliente";
                tb.Text = $"Cadastro de Cliente ({controleCadastroCliente})";
                tb.ImageIndex = 16;
                tb.Controls.Add(u);
                Tuc_Aplicacao.TabPages.Add(tb);
            }
            else
            {
                MessageBox.Show("Não é possível abrir mais um cadastro de clientes.", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FechaAba(TabPage tb)
        {
            if (tb.Name == "CadastroCliente")
            {
                var result = MessageBox.Show("Deseja mesmo fechar o cadastro de clientes?", "Banco ByteBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    controleCadastroCliente = 0;
                    Tuc_Aplicacao.TabPages.Remove(tb);
                }
                return;
            }
            Tuc_Aplicacao.TabPages.Remove(tb);
        }
    }
}
