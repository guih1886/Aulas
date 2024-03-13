﻿namespace CursoWindowsForms.Forms
{
    partial class Form_Agencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agencia));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.apagaToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.byteBankDataSet = new CursoWindowsForms.ByteBankDataSet();
            this.agenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenciasTableAdapter = new CursoWindowsForms.ByteBankDataSetTableAdapters.AgenciasTableAdapter();
            this.tableAdapterManager = new CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager();
            this.agenciasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.agenciasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agenciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasBindingNavigator)).BeginInit();
            this.agenciasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagaToolStripButton2});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(551, 25);
            this.Tls_Principal.TabIndex = 6;
            this.Tls_Principal.Text = "toolStrip1";
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
            // byteBankDataSet
            // 
            this.byteBankDataSet.DataSetName = "ByteBankDataSet";
            this.byteBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenciasBindingSource
            // 
            this.agenciasBindingSource.DataMember = "Agencias";
            this.agenciasBindingSource.DataSource = this.byteBankDataSet;
            // 
            // agenciasTableAdapter
            // 
            this.agenciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgenciasTableAdapter = this.agenciasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Clientes2TableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agenciasBindingNavigator
            // 
            this.agenciasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agenciasBindingNavigator.BindingSource = this.agenciasBindingSource;
            this.agenciasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agenciasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agenciasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agenciasBindingNavigatorSaveItem});
            this.agenciasBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.agenciasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agenciasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agenciasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agenciasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agenciasBindingNavigator.Name = "agenciasBindingNavigator";
            this.agenciasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agenciasBindingNavigator.Size = new System.Drawing.Size(551, 25);
            this.agenciasBindingNavigator.TabIndex = 7;
            this.agenciasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // agenciasBindingNavigatorSaveItem
            // 
            this.agenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agenciasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agenciasBindingNavigatorSaveItem.Image")));
            this.agenciasBindingNavigatorSaveItem.Name = "agenciasBindingNavigatorSaveItem";
            this.agenciasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.agenciasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.agenciasBindingNavigatorSaveItem.Click += new System.EventHandler(this.agenciasBindingNavigatorSaveItem_Click);
            // 
            // agenciasDataGridView
            // 
            this.agenciasDataGridView.AutoGenerateColumns = false;
            this.agenciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.agenciasDataGridView.DataSource = this.agenciasBindingSource;
            this.agenciasDataGridView.Location = new System.Drawing.Point(12, 53);
            this.agenciasDataGridView.Name = "agenciasDataGridView";
            this.agenciasDataGridView.Size = new System.Drawing.Size(527, 396);
            this.agenciasDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Agencia";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da Agência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 280F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da agência";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // Form_Agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 461);
            this.Controls.Add(this.agenciasDataGridView);
            this.Controls.Add(this.agenciasBindingNavigator);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agencia";
            this.Text = "Cadastro de Agência";
            this.Load += new System.EventHandler(this.Form_Agencia_Load);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasBindingNavigator)).EndInit();
            this.agenciasBindingNavigator.ResumeLayout(false);
            this.agenciasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton apagaToolStripButton2;
        private ByteBankDataSet byteBankDataSet;
        private System.Windows.Forms.BindingSource agenciasBindingSource;
        private ByteBankDataSetTableAdapters.AgenciasTableAdapter agenciasTableAdapter;
        private ByteBankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agenciasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agenciasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView agenciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}