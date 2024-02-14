namespace CursoWindowsForms
{
    partial class Form_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicial));
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.Btn_AbrirKey = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(314, 242);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(93, 29);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(13, 61);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.Btn_ModificaLabel.TabIndex = 2;
            this.Btn_ModificaLabel.Text = "Modificar Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(13, 35);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(209, 20);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Btn_AbrirKey
            // 
            this.Btn_AbrirKey.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AbrirKey.Image")));
            this.Btn_AbrirKey.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AbrirKey.Location = new System.Drawing.Point(13, 112);
            this.Btn_AbrirKey.Name = "Btn_AbrirKey";
            this.Btn_AbrirKey.Size = new System.Drawing.Size(209, 68);
            this.Btn_AbrirKey.TabIndex = 4;
            this.Btn_AbrirKey.Text = "Abrir Key";
            this.Btn_AbrirKey.UseVisualStyleBackColor = true;
            this.Btn_AbrirKey.Click += new System.EventHandler(this.Btn_AbrirKey_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Image = global::CursoWindowsForms.Properties.Resources.senha__1_;
            this.Btn_Senha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Senha.Location = new System.Drawing.Point(228, 112);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(179, 68);
            this.Btn_Senha.TabIndex = 5;
            this.Btn_Senha.Text = "Verificador De Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Location = new System.Drawing.Point(13, 186);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(209, 50);
            this.Btn_Mascara.TabIndex = 6;
            this.Btn_Mascara.Text = "Mascara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Validador CPF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            this.lbl_Titulo.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Form_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_AbrirKey);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Inicial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModificaLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
        private System.Windows.Forms.Button Btn_AbrirKey;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

