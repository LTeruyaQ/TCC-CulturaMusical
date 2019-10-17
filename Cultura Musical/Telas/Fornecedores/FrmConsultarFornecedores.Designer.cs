namespace Cultura_Musical.Telas.Fornecedores
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNMFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Fornecedor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNFornecedor
            // 
            this.txtNFornecedor.Location = new System.Drawing.Point(210, 112);
            this.txtNFornecedor.Name = "txtNFornecedor";
            this.txtNFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtNFornecedor.TabIndex = 1;
            this.txtNFornecedor.TextChanged += new System.EventHandler(this.txtNFornecedor_TextChanged);
            // 
            // dgvNMFornecedor
            // 
            this.dgvNMFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNMFornecedor.Location = new System.Drawing.Point(70, 159);
            this.dgvNMFornecedor.Name = "dgvNMFornecedor";
            this.dgvNMFornecedor.Size = new System.Drawing.Size(240, 150);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmConsultarFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNMFornecedor);
            this.Controls.Add(this.txtNFornecedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarFornecedores";
            this.Text = "lab";
            this.Load += new System.EventHandler(this.FrmConsultarFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNMFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNFornecedor;
        private System.Windows.Forms.DataGridView dgvNMFornecedor;
        private System.Windows.Forms.Label label2;
    }
}