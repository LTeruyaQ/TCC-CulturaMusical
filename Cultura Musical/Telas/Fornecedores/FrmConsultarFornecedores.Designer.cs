﻿namespace Cultura_Musical.Telas.Fornecedores
{
    partial class FrmConsultarFornecedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNFornecedor = new System.Windows.Forms.TextBox();
            this.dgvNMFornecedor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.alterar = new System.Windows.Forms.DataGridViewImageColumn();
            this.remover = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNMFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Fornecedor:";
            // 
            // txtNFornecedor
            // 
            this.txtNFornecedor.Location = new System.Drawing.Point(216, 99);
            this.txtNFornecedor.Name = "txtNFornecedor";
            this.txtNFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtNFornecedor.TabIndex = 1;
            this.txtNFornecedor.TextChanged += new System.EventHandler(this.txtNFornecedor_TextChanged);
            // 
            // dgvNMFornecedor
            // 
            this.dgvNMFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNMFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alterar,
            this.remover});
            this.dgvNMFornecedor.Location = new System.Drawing.Point(45, 152);
            this.dgvNMFornecedor.Name = "dgvNMFornecedor";
            this.dgvNMFornecedor.Size = new System.Drawing.Size(329, 211);
            this.dgvNMFornecedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultar Fornecedor";
            // 
            // alterar
            // 
            this.alterar.HeaderText = "Column1";
            this.alterar.Image = global::Cultura_Musical.Properties.Resources.lapis;
            this.alterar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.alterar.Name = "alterar";
            this.alterar.ReadOnly = true;
            this.alterar.Width = 20;
            // 
            // remover
            // 
            this.remover.HeaderText = "Column1";
            this.remover.Image = global::Cultura_Musical.Properties.Resources.lixeira;
            this.remover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.remover.Name = "remover";
            this.remover.ReadOnly = true;
            this.remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remover.Width = 20;
            // 
            // FrmConsultarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNMFornecedor);
            this.Controls.Add(this.txtNFornecedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarFornecedores";
            this.Text = "lab";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNMFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNFornecedor;
        private System.Windows.Forms.DataGridView dgvNMFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn alterar;
        private System.Windows.Forms.DataGridViewImageColumn remover;
    }
}