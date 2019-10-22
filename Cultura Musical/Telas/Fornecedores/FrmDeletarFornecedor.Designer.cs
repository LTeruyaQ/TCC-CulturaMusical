namespace Cultura_Musical.Telas.Fornecedores
{
    partial class FrmDeletarFornecedor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deletar Fornecedor";
            // 
            // txtNFornecedor
            // 
            this.txtNFornecedor.Location = new System.Drawing.Point(243, 124);
            this.txtNFornecedor.Name = "txtNFornecedor";
            this.txtNFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtNFornecedor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do Fornecedor:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(191, 195);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // FrmDeletarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 385);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNFornecedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeletarFornecedor";
            this.Text = "FrmDeletarFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletar;
    }
}