namespace CursoWindowsForms.Forms
{
    partial class Form_Busca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Busca));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apagaToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Lsb_ListaClientes = new System.Windows.Forms.ListBox();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.apagaToolStripButton2});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(481, 25);
            this.Tls_Principal.TabIndex = 6;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.ToolTipText = "Salvar busca de cliente";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // apagaToolStripButton2
            // 
            this.apagaToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apagaToolStripButton2.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.apagaToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apagaToolStripButton2.Name = "apagaToolStripButton2";
            this.apagaToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.apagaToolStripButton2.ToolTipText = "Fecha a tela de busca de cliente";
            this.apagaToolStripButton2.Click += new System.EventHandler(this.apagaToolStripButton2_Click);
            // 
            // Lsb_ListaClientes
            // 
            this.Lsb_ListaClientes.FormattingEnabled = true;
            this.Lsb_ListaClientes.Location = new System.Drawing.Point(13, 29);
            this.Lsb_ListaClientes.Name = "Lsb_ListaClientes";
            this.Lsb_ListaClientes.Size = new System.Drawing.Size(456, 303);
            this.Lsb_ListaClientes.TabIndex = 7;
            // 
            // Form_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 349);
            this.Controls.Add(this.Lsb_ListaClientes);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Busca";
            this.Text = "Busca";
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton apagaToolStripButton2;
        private System.Windows.Forms.ListBox Lsb_ListaClientes;
    }
}