namespace CursoWindowsForms
{
    partial class Form_Mascara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mascara));
            this.Msk_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Conteudo = new System.Windows.Forms.Label();
            this.Lbl_MmascaraAtiva = new System.Windows.Forms.Label();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Btn_CEP = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_TextBox
            // 
            resources.ApplyResources(this.Msk_TextBox, "Msk_TextBox");
            this.Msk_TextBox.Name = "Msk_TextBox";
            this.Msk_TextBox.RejectInputOnFirstFailure = true;
            // 
            // Lbl_Conteudo
            // 
            resources.ApplyResources(this.Lbl_Conteudo, "Lbl_Conteudo");
            this.Lbl_Conteudo.Name = "Lbl_Conteudo";
            // 
            // Lbl_MmascaraAtiva
            // 
            resources.ApplyResources(this.Lbl_MmascaraAtiva, "Lbl_MmascaraAtiva");
            this.Lbl_MmascaraAtiva.Name = "Lbl_MmascaraAtiva";
            // 
            // Btn_Hora
            // 
            resources.ApplyResources(this.Btn_Hora, "Btn_Hora");
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Btn_CEP
            // 
            resources.ApplyResources(this.Btn_CEP, "Btn_CEP");
            this.Btn_CEP.Name = "Btn_CEP";
            this.Btn_CEP.UseVisualStyleBackColor = true;
            this.Btn_CEP.Click += new System.EventHandler(this.Btn_CEP_Click);
            // 
            // Btn_Moeda
            // 
            resources.ApplyResources(this.Btn_Moeda, "Btn_Moeda");
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Btn_Data
            // 
            resources.ApplyResources(this.Btn_Data, "Btn_Data");
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Senha
            // 
            resources.ApplyResources(this.Btn_Senha, "Btn_Senha");
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Telefone
            // 
            resources.ApplyResources(this.Btn_Telefone, "Btn_Telefone");
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_VerConteudo
            // 
            resources.ApplyResources(this.Btn_VerConteudo, "Btn_VerConteudo");
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Form_Mascara
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_VerConteudo);
            this.Controls.Add(this.Btn_Telefone);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Moeda);
            this.Controls.Add(this.Btn_CEP);
            this.Controls.Add(this.Btn_Hora);
            this.Controls.Add(this.Lbl_MmascaraAtiva);
            this.Controls.Add(this.Lbl_Conteudo);
            this.Controls.Add(this.Msk_TextBox);
            this.Name = "Form_Mascara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_TextBox;
        private System.Windows.Forms.Label Lbl_Conteudo;
        private System.Windows.Forms.Label Lbl_MmascaraAtiva;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Button Btn_CEP;
        private System.Windows.Forms.Button Btn_Moeda;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_VerConteudo;
    }
}