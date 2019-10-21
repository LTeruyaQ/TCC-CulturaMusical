namespace Cultura_Musical.Telas.Produtos
{
    partial class FrmDeletarProduto
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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCertezas = new System.Windows.Forms.GroupBox();
            this.btnNão = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbCertezas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(233, 116);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(121, 21);
            this.cboProduto.TabIndex = 31;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 33;
            this.label1.Text = "DELETAR PRODUTO";
            // 
            // gbCertezas
            // 
            this.gbCertezas.Controls.Add(this.btnNão);
            this.gbCertezas.Controls.Add(this.btnSim);
            this.gbCertezas.Controls.Add(this.label3);
            this.gbCertezas.Location = new System.Drawing.Point(74, 205);
            this.gbCertezas.Name = "gbCertezas";
            this.gbCertezas.Size = new System.Drawing.Size(391, 110);
            this.gbCertezas.TabIndex = 34;
            this.gbCertezas.TabStop = false;
            this.gbCertezas.Visible = false;
            // 
            // btnNão
            // 
            this.btnNão.Location = new System.Drawing.Point(225, 63);
            this.btnNão.Name = "btnNão";
            this.btnNão.Size = new System.Drawing.Size(87, 23);
            this.btnNão.TabIndex = 33;
            this.btnNão.Text = "Não";
            this.btnNão.UseVisualStyleBackColor = true;
            this.btnNão.Click += new System.EventHandler(this.btnNão_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(53, 63);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(87, 23);
            this.btnSim.TabIndex = 32;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tem certeza?";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(233, 160);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmDeletarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gbCertezas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeletarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeletarProduto";
            this.gbCertezas.ResumeLayout(false);
            this.gbCertezas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCertezas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNão;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnExcluir;
    }
}