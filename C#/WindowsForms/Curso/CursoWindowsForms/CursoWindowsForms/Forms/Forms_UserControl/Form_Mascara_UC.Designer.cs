﻿namespace CursoWindowsForms.Forms.Forms_UserControl
{
    partial class Form_Mascara_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.Btn_CEP = new System.Windows.Forms.Button();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Lbl_MmascaraAtiva = new System.Windows.Forms.Label();
            this.Lbl_Conteudo = new System.Windows.Forms.Label();
            this.Msk_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_VerConteudo
            // 
            this.Btn_VerConteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_VerConteudo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_VerConteudo.Location = new System.Drawing.Point(1, 168);
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.Size = new System.Drawing.Size(258, 37);
            this.Btn_VerConteudo.TabIndex = 19;
            this.Btn_VerConteudo.Text = "Ver Conteúdo";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Btn_Telefone
            // 
            this.Btn_Telefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Telefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Telefone.Location = new System.Drawing.Point(167, 125);
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.Size = new System.Drawing.Size(89, 37);
            this.Btn_Telefone.TabIndex = 18;
            this.Btn_Telefone.Text = "Telefone";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Senha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Senha.Location = new System.Drawing.Point(79, 125);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(80, 37);
            this.Btn_Senha.TabIndex = 17;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Data.Location = new System.Drawing.Point(3, 125);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(68, 37);
            this.Btn_Data.TabIndex = 16;
            this.Btn_Data.Text = "Data";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Moeda
            // 
            this.Btn_Moeda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Moeda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Moeda.Location = new System.Drawing.Point(166, 82);
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.Size = new System.Drawing.Size(91, 37);
            this.Btn_Moeda.TabIndex = 15;
            this.Btn_Moeda.Text = "Moeda";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Btn_CEP
            // 
            this.Btn_CEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_CEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_CEP.Location = new System.Drawing.Point(79, 82);
            this.Btn_CEP.Name = "Btn_CEP";
            this.Btn_CEP.Size = new System.Drawing.Size(82, 37);
            this.Btn_CEP.TabIndex = 14;
            this.Btn_CEP.Text = "CEP";
            this.Btn_CEP.UseVisualStyleBackColor = true;
            this.Btn_CEP.Click += new System.EventHandler(this.Btn_CEP_Click);
            // 
            // Btn_Hora
            // 
            this.Btn_Hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Hora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Hora.Location = new System.Drawing.Point(3, 82);
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.Size = new System.Drawing.Size(68, 37);
            this.Btn_Hora.TabIndex = 13;
            this.Btn_Hora.Text = "Hora";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Lbl_MmascaraAtiva
            // 
            this.Lbl_MmascaraAtiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_MmascaraAtiva.AutoSize = true;
            this.Lbl_MmascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_MmascaraAtiva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_MmascaraAtiva.Location = new System.Drawing.Point(3, 47);
            this.Lbl_MmascaraAtiva.Name = "Lbl_MmascaraAtiva";
            this.Lbl_MmascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.Lbl_MmascaraAtiva.TabIndex = 12;
            // 
            // Lbl_Conteudo
            // 
            this.Lbl_Conteudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Conteudo.AutoSize = true;
            this.Lbl_Conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Conteudo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_Conteudo.Location = new System.Drawing.Point(3, 218);
            this.Lbl_Conteudo.Name = "Lbl_Conteudo";
            this.Lbl_Conteudo.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Conteudo.TabIndex = 11;
            // 
            // Msk_TextBox
            // 
            this.Msk_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Msk_TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Msk_TextBox.Location = new System.Drawing.Point(-2, 3);
            this.Msk_TextBox.Name = "Msk_TextBox";
            this.Msk_TextBox.RejectInputOnFirstFailure = true;
            this.Msk_TextBox.Size = new System.Drawing.Size(258, 26);
            this.Msk_TextBox.TabIndex = 10;
            // 
            // Form_Mascara_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Name = "Form_Mascara_UC";
            this.Size = new System.Drawing.Size(259, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VerConteudo;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Moeda;
        private System.Windows.Forms.Button Btn_CEP;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Label Lbl_MmascaraAtiva;
        private System.Windows.Forms.Label Lbl_Conteudo;
        private System.Windows.Forms.MaskedTextBox Msk_TextBox;
    }
}
