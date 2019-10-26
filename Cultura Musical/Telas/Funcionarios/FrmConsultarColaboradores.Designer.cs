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
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaFuncionario
            // 
            this.dgvConsultaFuncionario.AllowUserToAddRows = false;
            this.dgvConsultaFuncionario.AllowUserToDeleteRows = false;
            this.dgvConsultaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaFuncionario.Location = new System.Drawing.Point(50, 92);
            this.dgvConsultaFuncionario.Name = "dgvConsultaFuncionario";
            this.dgvConsultaFuncionario.ReadOnly = true;
            this.dgvConsultaFuncionario.Size = new System.Drawing.Size(489, 347);
            this.dgvConsultaFuncionario.TabIndex = 0;
            this.dgvConsultaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaFuncionario_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Funcionário:";
            // 
            // txtNomeFuncionário
            // 
            this.txtNomeFuncionário.Location = new System.Drawing.Point(188, 63);
            this.txtNomeFuncionário.Name = "txtNomeFuncionário";
            this.txtNomeFuncionário.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFuncionário.TabIndex = 2;
            this.txtNomeFuncionário.TextChanged += new System.EventHandler(this.txtNomeFuncionário_TextChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(348, 66);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consultar Colaborador";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "alterar";
            this.Column1.Image = global::Cultura_Musical.Properties.Resources.lapis;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "excluir";
            this.Column2.Image = global::Cultura_Musical.Properties.Resources.lixeira;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 20;
            // 
            // FrmConsultarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFuncionário);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarFuncionarios";
            this.Text = "FrmConsultarFuncionarios";
            this.Load += new System.EventHandler(this.FrmConsultarFuncionarios_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
    }
}