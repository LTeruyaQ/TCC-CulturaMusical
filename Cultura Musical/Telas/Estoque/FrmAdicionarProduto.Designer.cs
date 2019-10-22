namespace Cultura_Musical.Telas.Produtos
{
    partial class FrmAdicionarProduto
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 26;
            this.label1.Text = "Adicionar Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantidade:";
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(559, 139);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(100, 20);
            this.nudQtd.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(198, 140);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Preço:";
            // 
            // nudPreco
            // 
            this.nudPreco.Location = new System.Drawing.Point(412, 206);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(100, 20);
            this.nudPreco.TabIndex = 36;
            // 
            // FrmAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPreco);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdicionarProduto";
            this.Text = "FrmAdicionarProduto";
            this.Load += new System.EventHandler(this.FrmAdicionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPreco;
    }
}