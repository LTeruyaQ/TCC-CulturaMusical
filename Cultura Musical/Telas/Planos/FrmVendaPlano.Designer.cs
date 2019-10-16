namespace Cultura_Musical.Telas.Planos
{
    partial class cbo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmarPlano = new System.Windows.Forms.Button();
            this.cboPlano = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "R.G:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(144, 117);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
            // 
            // btnConfirmarPlano
            // 
            this.btnConfirmarPlano.Location = new System.Drawing.Point(121, 213);
            this.btnConfirmarPlano.Name = "btnConfirmarPlano";
            this.btnConfirmarPlano.Size = new System.Drawing.Size(124, 38);
            this.btnConfirmarPlano.TabIndex = 7;
            this.btnConfirmarPlano.Text = "Confirmar Plano";
            this.btnConfirmarPlano.UseVisualStyleBackColor = true;
            this.btnConfirmarPlano.Click += new System.EventHandler(this.btnConfirmarPlano_Click);
            // 
            // cboPlano
            // 
            this.cboPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlano.FormattingEnabled = true;
            this.cboPlano.Items.AddRange(new object[] {
            "Ouro"});
            this.cboPlano.Location = new System.Drawing.Point(144, 153);
            this.cboPlano.Name = "cboPlano";
            this.cboPlano.Size = new System.Drawing.Size(101, 21);
            this.cboPlano.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Plano";
            // 
            // cbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPlano);
            this.Controls.Add(this.btnConfirmarPlano);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cbo";
            this.Text = "FrmVendaPlano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Button btnConfirmarPlano;
        private System.Windows.Forms.ComboBox cboPlano;
        private System.Windows.Forms.Label label4;
    }
}