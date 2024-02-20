using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CursoWindowsForms.Forms
{
    public partial class Form_Menu_Flutuante : Form
    {
        public Form_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Form_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contexMenu = new ContextMenuStrip();

                var item1 = desenhaItemMenu("Item 1", "Frm_DemonstracaoKey", "1.1", "1.2");
                var item2 = desenhaItemMenu("Item 2", "chave");
                var item3 = desenhaItemMenu("Item 3", "");

                item1.Click += new EventHandler(item1_Click);
                item1.DropDownItems[0].Click += new EventHandler(drops1_Click);
                item1.DropDownItems[1].Click += new EventHandler(drops2_Click);
                item2.Click += new EventHandler(item1_Click);
                item3.Click += new EventHandler(item1_Click);


                contexMenu.Items.Add(item1);
                contexMenu.Items.Add(item2);
                contexMenu.Items.Add(item3);

                contexMenu.Show(this, new Point(e.X, e.Y));
            }

            ToolStripMenuItem desenhaItemMenu(string text, string nomeImagem, params string[] dropdowns)
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
        }

        private void item1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deu certo");
        }
        private void item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deu certo");
        }
        private void item3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deu certo");
        }
        private void drops1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("drop 1");
        }
        private void drops2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("drop 2");
        }
    }
}
