namespace CursoWindowsForms.Forms
{
    partial class Form_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sobre));
            this.Lbl_Sobre = new System.Windows.Forms.Label();
            this.Lbl_Link = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Lbl_Sobre
            // 
            this.Lbl_Sobre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sobre.Location = new System.Drawing.Point(12, 70);
            this.Lbl_Sobre.Name = "Lbl_Sobre";
            this.Lbl_Sobre.Size = new System.Drawing.Size(461, 23);
            this.Lbl_Sobre.TabIndex = 0;
            this.Lbl_Sobre.Text = "Desenvolvido por Guilherme Henrique";
            this.Lbl_Sobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Link
            // 
            this.Lbl_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Link.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Link.Image = global::CursoWindowsForms.Properties.Resources.linkedin;
            this.Lbl_Link.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Lbl_Link.Location = new System.Drawing.Point(13, 111);
            this.Lbl_Link.Name = "Lbl_Link";
            this.Lbl_Link.Size = new System.Drawing.Size(532, 95);
            this.Lbl_Link.TabIndex = 1;
            this.Lbl_Link.TabStop = true;
            this.Lbl_Link.Text = "https://www.linkedin.com/in/guih1886/";
            this.Lbl_Link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(11, 206);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(462, 95);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://guih1886.com.br/";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 357);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Lbl_Link);
            this.Controls.Add(this.Lbl_Sobre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Sobre;
        private System.Windows.Forms.LinkLabel Lbl_Link;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}