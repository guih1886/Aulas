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
    public partial class Form_Agencia : Form
    {
        public Form_Agencia()
        {
            InitializeComponent();
        }

        private void apagaToolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agenciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.byteBankDataSet);

        }

        private void Form_Agencia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'byteBankDataSet.Agencias'. Você pode movê-la ou removê-la conforme necessário.
            this.agenciasTableAdapter.Fill(this.byteBankDataSet.Agencias);

        }
    }
}
