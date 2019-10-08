namespace Cultura_Musical.Telas.Funcionario
{
    partial class FrmConsultarFuncionarios
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
            this.dgvConsultaFuncionario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFuncionário = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaFuncionario
            // 
            this.dgvConsultaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFuncionario.Location = new System.Drawing.Point(28, 105);
            this.dgvConsultaFuncionario.Name = "dgvConsultaFuncionario";
            this.dgvConsultaFuncionario.Size = new System.Drawing.Size(489, 347);
            this.dgvConsultaFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Funcionário:";
            // 
            // txtNomeFuncionário
            // 
            this.txtNomeFuncionário.Location = new System.Drawing.Point(144, 63);
            this.txtNomeFuncionário.Name = "txtNomeFuncionário";
            this.txtNomeFuncionário.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFuncionário.TabIndex = 2;
            this.txtNomeFuncionário.TextChanged += new System.EventHandler(this.txtNomeFuncionário_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(304, 66);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargo:";
            // 
            // FrmConsultarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 464);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFuncionário);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaFuncionario);
            this.Name = "FrmConsultarFuncionarios";
            this.Text = "FrmConsultarFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFuncionário;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label2;
    }
}