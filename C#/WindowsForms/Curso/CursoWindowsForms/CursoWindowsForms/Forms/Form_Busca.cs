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
    public partial class Form_Busca : Form
    {
        private List<List<string>> ListaClientes;
        public string idSelected { get; set; }

        public Form_Busca(List<List<string>> listaBusca)
        {
            InitializeComponent();
            ListaClientes = listaBusca;
            PreencherLista();
            Lsb_ListaClientes.Sorted = true;
        }

        private void PreencherLista()
        {
            foreach (var item in ListaClientes)
            {
                Lsb_ListaClientes.Items.Add($"{item[0]} - {item[1]}");
            }
        }

        private void apagaToolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            idSelected = ListaClientes[Lsb_ListaClientes.SelectedIndex][0];
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
