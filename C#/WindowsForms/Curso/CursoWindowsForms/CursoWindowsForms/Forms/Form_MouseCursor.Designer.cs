namespace CursoWindowsForms.Forms
{
    partial class Form_MouseCursor
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
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_X = new System.Windows.Forms.Label();
            this.Lbl_Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 173);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // Lbl_X
            // 
            this.Lbl_X.AutoSize = true;
            this.Lbl_X.Location = new System.Drawing.Point(87, 280);
            this.Lbl_X.Name = "Lbl_X";
            this.Lbl_X.Size = new System.Drawing.Size(0, 13);
            this.Lbl_X.TabIndex = 1;
            // 
            // Lbl_Y
            // 
            this.Lbl_Y.AutoSize = true;
            this.Lbl_Y.Location = new System.Drawing.Point(393, 280);
            this.Lbl_Y.Name = "Lbl_Y";
            this.Lbl_Y.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Y.TabIndex = 2;
            // 
            // Form_MouseCursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 342);
            this.Controls.Add(this.Lbl_Y);
            this.Controls.Add(this.Lbl_X);
            this.Controls.Add(this.button1);
            this.Name = "Form_MouseCursor";
            this.Text = "Form_MouseCursor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_X;
        private System.Windows.Forms.Label Lbl_Y;
    }
}